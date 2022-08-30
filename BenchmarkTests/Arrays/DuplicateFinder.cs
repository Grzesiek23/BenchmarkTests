namespace BenchmarkTests.Arrays;

public class DuplicateFinder
{
    public bool FindDuplicates(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool FindDuplicatesWithHashSet(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }

            set.Add(num);
        }

        return false;
    }

    public bool FindDuplicatesWithLinq(int[] nums)
    {
        return nums.GroupBy(x => x).Any(x => x.Count() > 1);
    }

    public bool FindDuplicatesWithListContainsAndForeach(int[] nums)
    {
        var list = new List<int>();
        foreach (var num in nums)
        {
            if (list.Contains(num))
                return true;
            list.Add(num);
        }

        return false;
    }

    public bool FindDuplicatesWithListContainsAndFor(int[] nums)
    {
        var list = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (list.Contains(nums[i]))
                return true;
            list.Add(nums[i]);
        }

        return false;
    }
}