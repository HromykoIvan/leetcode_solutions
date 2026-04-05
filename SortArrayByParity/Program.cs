var sol = new Solution();
//var result = sol.RemoveElement(new[] {0,1,2,2,3,0,4,2}, 2);
var result = sol.SortArrayByParity([3,2,2,3]);
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);
public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        // Two-pointer approach: O(n) time, O(1) space
        // Optimized: bitwise operations instead of modulo, simplified logic
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            // Move left pointer until we find an odd number (bitwise check: last bit == 1)
            // nums[left] & 1 is faster than nums[left] % 2
            while (left < right && (nums[left] & 1) == 0)
            {
                left++;
            }

            // Move right pointer until we find an even number (bitwise check: last bit == 0)
            while (left < right && (nums[right] & 1) == 1)
            {
                right--;
            }

            // Swap odd at left with even at right
            if (left < right)
            {
                // Direct swap without tuple (slightly faster)
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }

        return nums;
    }
}