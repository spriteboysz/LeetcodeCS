/*
 * Author: Deean
 * Date: 2023-04-08 09:32:17
 * FileName: P0121.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0121 {
    public class Solution {
        public int MaxProfit(int[] prices) {
            int maximum = 0, minprice = Int32.MaxValue;
            for (int i = 0, n = prices.Length; i < n; i++) {
                if (prices[i] < minprice) {
                    minprice = prices[i];
                } else if (prices[i] - minprice > maximum) {
                    maximum = prices[i] - minprice;
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
        Console.WriteLine(ans);
    }
}