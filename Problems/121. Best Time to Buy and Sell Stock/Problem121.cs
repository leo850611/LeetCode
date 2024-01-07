using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems._121._Best_Time_to_Buy_and_Sell_Stock
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public class Problem121
    {
        public int MaxProfit(int[] prices)
        {
            var profitList = new List<int> {0};
            for (var i = 0; i < prices.Length - 1; i++)
            {
                var currentProfit = prices[i + 1] - prices[i];
                var sumProfit = profitList[i] + currentProfit;
                var maxProfit = Math.Max(currentProfit, sumProfit);
                profitList.Add(maxProfit);
            }

            return profitList.Max();
        }
    }
}