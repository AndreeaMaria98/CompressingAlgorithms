using CompressingAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressingAlgorithms.Helpers
{
    public static class CompressingFactory
    {
        public static Compression CreateAlgorithm(CompressionType type)
        {
            switch (type)
            {
                case CompressionType.Brotli:
                    return new BrotliCompression();
                case CompressionType.Deflate:
                    return new DeflateCompression();
                case CompressionType.GZip:
                    return new GZipCompression();
                case CompressionType.ZLib:
                    return new ZLibCompression();
                default:
                    return null;
            }
        }
    }
}
