/*
    You are given an array prices where prices[i] is the price of a given stock on the ith day.
    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int l = 0;
        int r = 1;
        int maxProfit = 0;

        for (; r < prices.Length; r++)
        {
            // profitable ?
            if (prices[r] > prices[l])
            {
                int profit = prices[r] - prices[l];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            else
            {
                l = r;
            }
        }
        return maxProfit;
    }
}