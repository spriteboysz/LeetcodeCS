/*
 * Author: Deean
 * Date: 2023-05-21 10:20:23
 * FileName: 剑指 Offer 63. 股票的最大利润.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_63__股票的最大利润 {
    public class Solution {
        public int MaxProfit(int[] prices) {
            int maximum = 0, minprice = Int32.MaxValue;
            foreach (var price in prices) {
                minprice = Math.Min(minprice, price);
                maximum = Math.Max(maximum, price - minprice);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProfit(new[] { 7, 2, 5, 3, 6, 4, 1 });
        Console.WriteLine(ans);
    }
}