/*
 * Author: Deean
 * Date: 2023-12-24 22:48:14
 * FileName: LCR0188.cs
 * Description: LCR 188. 买卖芯片的最佳时机
 */

using System;

namespace LCP;

public class LCR0188 {
    public class Solution {
        public int BestTiming(int[] prices) {
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
        var ans = s.BestTiming(new[] { 3, 6, 2, 9, 8, 5 });
        Console.WriteLine(ans);
    }
}