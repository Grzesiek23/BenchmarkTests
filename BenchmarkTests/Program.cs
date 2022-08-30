using BenchmarkDotNet.Running;
using BenchmarkTests.Arrays;

namespace BenchmarkTests;

class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<DuplicateFinderBenchmarks>();
    }
}