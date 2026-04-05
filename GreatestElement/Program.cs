var sol = new Solution();
var result = sol.ReplaceElements([17,18,5,4,6,1]);
//var result = sol.Merge(new[] {2,0}, 1,new[] {1}, 1);
string arrayString = "[" + String.Join(",", result) + "Expected: [18,6,6,6,1,-1]" + "]";
Console.WriteLine(arrayString);

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int cur = arr[i];
            arr[i] = max;
            if (cur > max) max = cur;
        }
        return arr;
    }
}
