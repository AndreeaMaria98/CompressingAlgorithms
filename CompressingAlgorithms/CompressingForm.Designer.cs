
namespace CompressingAlgorithms
{
    partial class CompressingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.compressRadioButton = new System.Windows.Forms.RadioButton();
            this.decompressRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Algorithm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Location = new System.Drawing.Point(79, 77);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(206, 21);
            this.algorithmComboBox.TabIndex = 6;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(464, 36);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 8;
            this.inputButton.Text = "Browse";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // compressRadioButton
            // 
            this.compressRadioButton.AutoSize = true;
            this.compressRadioButton.Location = new System.Drawing.Point(355, 78);
            this.compressRadioButton.Name = "compressRadioButton";
            this.compressRadioButton.Size = new System.Drawing.Size(71, 17);
            this.compressRadioButton.TabIndex = 10;
            this.compressRadioButton.TabStop = true;
            this.compressRadioButton.Text = "Compress";
            this.compressRadioButton.UseVisualStyleBackColor = true;
            // 
            // decompressRadioButton
            // 
            this.decompressRadioButton.AutoSize = true;
            this.decompressRadioButton.Location = new System.Drawing.Point(464, 78);
            this.decompressRadioButton.Name = "decompressRadioButton";
            this.decompressRadioButton.Size = new System.Drawing.Size(84, 17);
            this.decompressRadioButton.TabIndex = 11;
            this.decompressRadioButton.TabStop = true;
            this.decompressRadioButton.Text = "Decompress";
            this.decompressRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Results:";
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Location = new System.Drawing.Point(79, 150);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.ReadOnly = true;
            this.resultsRichTextBox.Size = new System.Drawing.Size(460, 221);
            this.resultsRichTextBox.TabIndex = 14;
            this.resultsRichTextBox.Text = "";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(355, 119);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 17;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(464, 119);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(79, 38);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(351, 20);
            this.inputTextBox.TabIndex = 19;
            // 
            // CompressingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 383);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.resultsRichTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decompressRadioButton);
            this.Controls.Add(this.compressRadioButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.algorithmComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CompressingForm";
            this.Text = "Compress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.RadioButton compressRadioButton;
        private System.Windows.Forms.RadioButton decompressRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

