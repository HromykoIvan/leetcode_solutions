var sol = new Solution();
//https://leetcode.com/problems/contains-duplicate/description
var result = sol.ContainsDuplicate([17,18,5,4,17,6,1]);
//var result = sol.Merge(new[] {2,0}, 1,new[] {1}, 1);
string arrayString = $"{result}";
Console.WriteLine(arrayString);

//1. O(n^2)
// public class Solution
// {
//     public bool ContainsDuplicate(int[] nums)
//     {
//         for (int i = 0; i < nums.Length - 1; i++)
//         {
//             for (int j = i + 1; j < nums.Length; j++)
//             {
//                 if (nums[i] == nums[j])
//                 {
//                     return true;
//                 }
//             }
//         }
//
//         return false;
//     }
// }
//O(n)
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var seen = new HashSet<int>();

        foreach (var num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }

            seen.Add(num);
        }

        return false;
    }
}