using BenchmarkDotNet.Attributes;

namespace BenchmarkTests.StringComparison;

public class StringComparisonBenchmarks
{
    private const string test1 = "Example](https://example.com)";

    [Benchmark]
    public bool StringComparisonOrdinal()
    {
        return test1.IndexOf("](", System.StringComparison.Ordinal) != -1;
    }

    [Benchmark]
    public bool StringComparisonCurrentCulture()
    {
        return test1.IndexOf("](", System.StringComparison.CurrentCulture) != -1;
    }

    [Benchmark]
    public bool StringComparisonInvariantCulture()
    {
        return test1.IndexOf("](", System.StringComparison.InvariantCulture) != -1;
    }
}