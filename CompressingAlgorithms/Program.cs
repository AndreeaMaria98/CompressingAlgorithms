using CompressingAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressingAlgorithms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CompressingForm());

            //Console.WriteLine("GZip");
            //Console.WriteLine("\tCompressing: " + GetTime(new GZipCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new GZipCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf.gz"));


            //Console.WriteLine("Deflate");
            //Console.WriteLine("\tCompressing: " + GetTime(new DeflateCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new DeflateCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf.def"));

            //Console.WriteLine("Brotli");
            //Console.WriteLine("\tCompressing: " + GetTime(new BrotliCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new BrotliCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf.br"));

            //Console.WriteLine("ZLib");
            //Console.WriteLine("\tCompressing: " + GetTime(new ZLibCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new ZLibCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\bilete_teatru.pdf.zlib"));


            //Console.WriteLine("GZip");
            //Console.WriteLine("\tCompressing: " + GetTime(new GZipCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\utile"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new GZipCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\utile"));


            //Console.WriteLine("Deflate");
            //Console.WriteLine("\tCompressing: " + GetTime(new DeflateCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\utile"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new DeflateCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\utile"));

            //Console.WriteLine("Brotli");
            //Console.WriteLine("\tCompressing: " + GetTime(new BrotliCompression(), true, @"C:\Users\stoia\OneDrive\Desktop\utile"));
            //Console.WriteLine("\tDecompressing: " + GetTime(new BrotliCompression(), false, @"C:\Users\stoia\OneDrive\Desktop\utile"));
        }
    }
}
