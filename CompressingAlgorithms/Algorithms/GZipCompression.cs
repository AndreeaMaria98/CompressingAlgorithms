using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressingAlgorithms.Algorithms
{
    public class GZipCompression : Compression
    {
        public GZipCompression()
        {
            Extension = ".gz";
        }
        public override string Compress(string input)
        {
            FileInfo fileToBeGZipped = new FileInfo(input);
            FileInfo gzipFileName = new FileInfo(input + Extension);
            using (FileStream fileToBeZippedAsStream = fileToBeGZipped.OpenRead())
            {
                using (FileStream gzipTargetAsStream = gzipFileName.Create())
                {
                    using (GZipStream gzipStream = new GZipStream(gzipTargetAsStream, CompressionMode.Compress))
                    {
                        try
                        {
                            fileToBeZippedAsStream.CopyTo(gzipStream);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return gzipFileName.FullName;
        }
        public override string Decompress(string output)
        {
            string decompressedFileName;
            FileInfo gzipFileName = new FileInfo(output);
            using (FileStream fileToDecompressAsStream = gzipFileName.OpenRead())
            {
                decompressedFileName = Path.ChangeExtension(output, null);
                using (FileStream decompressedStream = File.Create(decompressedFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(fileToDecompressAsStream, CompressionMode.Decompress))
                    {
                        try
                        {
                            decompressionStream.CopyTo(decompressedStream);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return decompressedFileName;
        }
    }
}
