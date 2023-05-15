using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests.Variables;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class VariablesInitializer
{
    public void EmptyArray()
    {
        var array = Array.Empty<int>();
    }
    
    public void EmptyArrayWithSize()
    {
        var array = new int[0];
    }
    
    public void EmptyList()
    {
        var list = new List<int>();
    }
    
    public void EmptyListByEnumerable()
    {
        var list = Enumerable.Empty<int>();

        list = new List<int>();

    }

}