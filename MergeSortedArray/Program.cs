var sol = new Solution();
var result = sol.Merge(new[] {1,2,3,0,0,0}, 3,new[] {2,5,6}, 3);
//var result = sol.Merge(new[] {2,0}, 1,new[] {1}, 1);
string arrayString = "[" + String.Join(",", result) + "]";
Console.WriteLine(arrayString);

public class Solution {
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var insertPosition = m + n - 1;
        m--;
        n--;

        while (n >= 0 )
        {
            if (m >= 0 && nums1[m] > nums2[n])
            {
                nums1[insertPosition] = nums1[m];
                m--;
            }
            else
            {
                nums1[insertPosition] = nums2[n];
                n--;
            }

            insertPosition--;
        }
        
        return nums1;
    }
}