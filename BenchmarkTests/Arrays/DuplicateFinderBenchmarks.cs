using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests.Arrays;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DuplicateFinderBenchmarks
{
    private static readonly int[] _array = Enumerable.Range(0, 1000).ToArray();
    private static readonly DuplicateFinder DuplicateFinder = new(); 
        
    
    [Benchmark(Baseline = true)]
    public bool FindDuplicates()
    {
        return DuplicateFinder.FindDuplicates(_array);
    }
    
    [Benchmark]
    public bool FindDuplicatesWithLinq()
    {
        return DuplicateFinder.FindDuplicatesWithLinq(_array);
    }
    
    [Benchmark]
    public bool FindDuplicatesWithLinqAndHashSet()
    {
        return DuplicateFinder.FindDuplicatesWithHashSet(_array);
    }
    
    [Benchmark]
    public bool FindDuplicatesWithListContainsAndForeach()
    {
        return DuplicateFinder.FindDuplicatesWithListContainsAndForeach(_array);
    }
    
    [Benchmark]
    public bool FindDuplicatesWithListContainsAndFor()
    {
        return DuplicateFinder.FindDuplicatesWithListContainsAndFor(_array);
    }
}