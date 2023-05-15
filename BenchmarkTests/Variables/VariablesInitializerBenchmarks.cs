using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests.Variables;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class VariablesInitializerBenchmarks
{
    private static readonly VariablesInitializer VariablesInitializer = new(); 
        
    
    [Benchmark(Baseline = true)]
    public void EmptyArray()
    {
        VariablesInitializer.EmptyArray();
    }
    
    [Benchmark]
    public void EmptyArrayWithSize()
    {
        VariablesInitializer.EmptyArrayWithSize();
    }
}