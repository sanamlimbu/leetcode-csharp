/*
    You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
    On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.
    Find and return the maximum profit you can achieve.
*/

// This is a peek and valley problem, sum of all the peaks is the solution
public class Solution
{

    public int MaxProfit(int[] prices)
    {
        int sum = 0;
        int i = 0, j = 1;
        for (; j < prices.Length;)
        {
            // profitable ?
            if (prices[i] < prices[j])
            {
                sum += prices[j] - prices[i];
                i++;
            }
            else
            {
                i = j;
            }
            j = i + 1;
        }
        return sum;
    }
}