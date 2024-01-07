var sol = new Solution();
//var result = sol.RemoveElement(new[] {0,1,2,2,3,0,4,2}, 2);
var result = sol.RemoveElement(new[] {3,2,2,3}, 3);
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var point1 = 0;
        var point2 = nums.Length - 1;
        var clearLenght = 0;

        while (point1 <= point2)
        {
            if (nums[point2] == val)
            {
                nums[point2] = -1;
                point2--;
            }
            else if (nums[point1] == val)
            {
                nums[point1] = nums[point2];
                nums[point2] = -1;
                clearLenght++;
                point1++;
                point2--;
            }
            else
            {
                point1++;
                clearLenght += 1;
            }
        }
        string arrayString = "[" + String.Join(",", nums) + "]";
        Console.WriteLine(arrayString);
        return clearLenght;
    }
}