var sol = new Solution();
var nums = new[] { 1, 0, 1 };
//var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
sol.MoveZeroes(nums);
string arrayString = "[" + String.Join(",", nums) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public void MoveZeroes(int[] nums) {
        // Two-pointer approach: O(n) time, O(1) space
        int writePos = 0;
        
        // Move all non-zero elements to the front
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[writePos] = nums[i];
                writePos++;
            }
        }
        
        // Fill the remaining positions with zeros
        for (int i = writePos; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}