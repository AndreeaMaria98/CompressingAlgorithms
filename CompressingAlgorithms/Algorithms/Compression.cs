using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressingAlgorithms.Algorithms
{
    public abstract class Compression
    {
        public string Extension { get; set; }
        public abstract string Compress(string input);
        public abstract string Decompress(string output);
    }
}
