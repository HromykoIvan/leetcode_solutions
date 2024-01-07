var sol = new Solution();
var result = sol.FindNumbers(new[] { 12, 345, 2, 6, 7896 });
Console.WriteLine(result);

public class Solution {
    public int FindNumbers(int[] nums)
    {
        return nums.Count(num => num.ToString().Length % 2 == 0);
    }
}