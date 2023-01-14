using CompressingAlgorithms.Algorithms;
using CompressingAlgorithms.Helpers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CompressingAlgorithms
{
    public partial class CompressingForm : Form
    {
        private BindingList<string> algorithms;
        private string _outputPath;

        public CompressingForm()
        {
            InitializeComponent();
            algorithms = new BindingList<string> { "Brotli", "Deflate", "GZip", "ZLib" };
            algorithmComboBox.DataSource = algorithms;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFileDialog = new OpenFileDialog();
            inputFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            inputFileDialog.RestoreDirectory = true;

            if (inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream inputStream = inputFileDialog.OpenFile())
                    {
                        if (inputStream != null)
                        {
                            inputTextBox.Text = inputFileDialog.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be read. \nException: " + ex.Message);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            compressRadioButton.Checked = false;
            decompressRadioButton.Checked = false;
            resultsRichTextBox.Text = string.Empty;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultsRichTextBox.Text))
            {
                resultsRichTextBox.Text += "\n";
            }
            if (string.IsNullOrEmpty(inputTextBox.Text) || (!compressRadioButton.Checked && !decompressRadioButton.Checked))
            {
                resultsRichTextBox.Text += "You did not complete the necessary data.";
                return;
            }

            CompressionType type = (CompressionType)algorithms.IndexOf(algorithmComboBox.SelectedItem.ToString());
            var algorithm = CompressingFactory.CreateAlgorithm(type);
            var isCompressing = compressRadioButton.Checked;

            if(!string.IsNullOrEmpty(resultsRichTextBox.Text))
            {
                resultsRichTextBox.Text += "\n";
            }
            resultsRichTextBox.Text += algorithmComboBox.SelectedItem.ToString() + " ";
            resultsRichTextBox.Text += isCompressing ? "Compressing: " : "Decompressing: \n";
            resultsRichTextBox.Text += "\n\tTime:" + GetTime(algorithm, isCompressing, inputTextBox.Text);
            resultsRichTextBox.Text += "\n\tSize:" + GetUsedMemory();
        }
        private double GetTime(Compression compression, bool isCompressing, string path)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (isCompressing)
            {
                _outputPath = compression.Compress(path);
            }
            else
            {
                _outputPath = compression.Decompress(path);
            }

            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }
        private string GetUsedMemory()
        {
            long length = new System.IO.FileInfo(_outputPath).Length;
            return length + " bytes";
        }
    }
}
