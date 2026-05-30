using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class MaxProfit_BestTimeToBuyAndSell
    {
        public static int MaxProfit_BruteForce(int[] arr) 
        {
            //[7,1,5,3,6,4]
            //buy:1
            //Sell: 6
            //Profit: Sell-buy => 6 - 1 = 5.

            //Time Complexity : O(n^2)
            //Space Complexity : O(1)

            if (arr is null || arr.Length < 2) //buy and sell requires atleast 2 prices
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            int maxProfit = 0;
            for (int i = 0; i < arr.Length-1; i++) //buy
            {
                for (int j = i + 1; j < arr.Length; j++) //sell
                {
                    int profit = arr[j] - arr[i];  //sell - buy
                    maxProfit = Math.Max(profit, maxProfit);
                }
            }
            return maxProfit;   //if maxProfit is negative or 0 return 0 otherwise return maxProfit
        }

        public static int MaxProfit_Optimized(int[] arr) 
        {
            // Summary:
            // We only need to know the lowest buying price seen so far.
            //
            // For each day:
            // 1. Track the minimum price encountered so far.
            // 2. Calculate profit if we sell today.
            // 3. Keep track of the maximum profit found.
            //
            // This avoids comparing every buy/sell pair and reduces
            // the solution from O(n²) to O(n).
            //
            // Example:
            // Prices: [7,1,5,3,6,4]
            //
            // Lowest price seen so far = 1
            // Best selling price = 6
            // Maximum profit = 5
            //
            // Time Complexity : O(n)
            // Space Complexity: O(1)

            if (arr is null || arr.Length < 2) //buy and sell requires atleast 2 prices
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            int minBuyingPrice = arr[0];
            int maxProfit = 0;
            
            for(int sell = 0; sell < arr.Length; sell++) 
            {
                minBuyingPrice = Math.Min(minBuyingPrice, arr[sell]);
                int profit = arr[sell] - minBuyingPrice;
                maxProfit = Math.Max(profit, maxProfit);
            }
            return maxProfit;
        }
    }
}
