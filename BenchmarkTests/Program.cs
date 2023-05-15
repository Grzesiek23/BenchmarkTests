using BenchmarkDotNet.Running;
using BenchmarkTests.StringComparison;
using BenchmarkTests.Variables;

namespace BenchmarkTests;

class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<StringComparisonBenchmarks>();
    }
}