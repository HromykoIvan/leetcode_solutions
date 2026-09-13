int[] nums = [1,2,1,2,1,2,3,1,3,2,4,4,4,4,4,4,4,4];
var k = 2;
var sol = new Solution();
var result = sol.TopKFrequent(nums, k);
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var collection = new Dictionary<int, int>();
        foreach (var t in nums)
        {
            if (!collection.TryAdd(t, 1))
            {
                collection[t]++;
            }
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach (var pair in collection)
        {
            buckets[pair.Value] ??= new List<int>();
            buckets[pair.Value].Add(pair.Key);
        }

        var result = new List<int>();
        for (int freq = buckets.Length - 1; freq >= 0; freq--)
        {
            if (buckets[freq] == null)
                continue;

            foreach (var number in buckets[freq])
            {
                result.Add(number);

                if (result.Count == k)
                    return result.ToArray();
            }
        }
        
        return result.ToArray();
    }
}