var sol = new Solution();
//var testArray = new[] {1,1,2};
var testArray = new[] {0,0,1,1,1,2,2,3,3,4};
Console.WriteLine($"Input array: [{String.Join(",", testArray)}]");

var result = sol.RemoveElement(testArray);
Console.WriteLine($"Result (unique count): {result}");
Console.WriteLine($"Modified array (first {result} elements): [{String.Join(",", testArray.Take(result))}]");

public class Solution {
    public int RemoveElement(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int k = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
