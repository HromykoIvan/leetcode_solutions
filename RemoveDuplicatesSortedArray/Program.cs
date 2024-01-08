var sol = new Solution();
//var result = sol.RemoveElement(new[] {1,1,2});
var result = sol.RemoveElement(new[] {0,0,1,1,1,2,2,3,3,4});
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

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