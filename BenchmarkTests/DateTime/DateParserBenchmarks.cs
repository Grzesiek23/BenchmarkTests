using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests.DateTime;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmarks
{
    private const string DateTime = "2022-09-16T13:23:03Z";
    private static readonly DateParser Parser = new();

    [Benchmark]
    public void GetYearFromDateTime()
    {
        Parser.GetYearFromDateTime(DateTime);
    }
}