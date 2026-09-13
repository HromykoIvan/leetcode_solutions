var sol = new Solution();

int[] nums = [2, 7, 11, 15];
var target = 9;
var result = sol.TwoSumOptimal(nums, target);
Console.WriteLine("Answer is: " + string.Join(", ", result));
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length -1; j > 0; j--)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }
        throw new InvalidOperationException("No solution was found.");
    }
    
    public int[] TwoSumOptimal(int[] nums, int target)
    {
        var indicesByNumber = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int requiredNumber = target - nums[i];

            if (indicesByNumber.TryGetValue(requiredNumber, out int requiredIndex))
            {
                return [requiredIndex, i];
            }

            indicesByNumber.TryAdd(nums[i], i);
        }

        throw new InvalidOperationException("No solution was found.");
    }
}