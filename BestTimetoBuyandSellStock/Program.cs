var sol = new Solution();
var result = sol.MaxProfit([7,1,5,3,6,4]);

Console.Write($"result: {result}");

public class Solution {
    public int MaxProfit(int[] prices)
    {
        var minPrice = prices[0];
        var maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}