https://leetcode.com/problems/best-time-to-buy-and-sell-stock/?envType=study-plan&id=data-structure-i

public class Solution {
    public int MaxProfit(int[] prices) {
        int minimum = Int32.MaxValue, profit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < minimum) minimum = prices[i];
            if(prices[i] - minimum > profit) profit = prices[i] - minimum;
        }
        return profit;
    }
}
