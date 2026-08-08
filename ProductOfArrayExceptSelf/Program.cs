var sol = new Solution();
var result = sol.ProductExceptSelf([-1,1,0,-3,3]);
PrintGroups(result);
static void PrintGroups(int[] nums)
{
        Console.Write("[" + string.Join(",", nums) + "]");
}

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        /*
        Old solution (your approach), commented out on purpose:

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int? product = null;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (product == null)
                    product = nums[j];
                else
                {
                    product *= nums[j];
                }
            }

            result[i] = product ?? 0;
        }

        return result;

        Why this is not accepted on LeetCode:
        - The logic is mostly correct, but it is too slow for large inputs.
        - Time complexity is O(n^2): for each index i, you iterate through the whole array again.
        - LeetCode expects an O(n) solution for this problem, so this approach often gets Time Limit Exceeded.
        */

        int n = nums.Length;
        int[] result = new int[n];

        // 1) Left pass:
        // result[i] stores the product of all numbers to the left of i.
        int leftProduct = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }

        // 2) Right pass:
        // Multiply by the product of all numbers to the right of i.
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }
}
