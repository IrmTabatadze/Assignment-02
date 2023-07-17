using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;
using Task_1;


var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();


