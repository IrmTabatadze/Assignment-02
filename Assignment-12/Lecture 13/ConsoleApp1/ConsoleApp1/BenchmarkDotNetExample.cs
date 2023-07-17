using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Task_1
{
    public class BenchmarkDotNetExample
    {
        private readonly CodeToBeBenchmark _code = new CodeToBeBenchmark();

        [Benchmark]
        public byte[] Sha512() => _code.Sha512();

        [Benchmark]
        public byte[] Md5() => _code.Md5();

        public static void Run()
        {
            var summary = BenchmarkRunner.Run<BenchmarkDotNetExample>();
        }
    }
}
