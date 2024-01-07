var sol = new Solution();
var result = sol.SortedSquares(new[] { -7,-3,2,3,11 });
foreach (var res in result)
{
    Console.WriteLine(res);
}

public class Solution {
    public int[] SortedSquares(int[] nums) {
        var n = nums.Length;
        var result = new int[n];

        var left = 0;
        var right = n - 1;
        var position = n - 1;

        while (left <= right)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[position] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[position] = nums[right] * nums[right];
                right--;
            }

            position--;
        }

        return result;
    }
}
