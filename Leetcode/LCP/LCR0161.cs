/*
 * Author: Deean
 * Date: 2023-12-06 20:12:15
 * FileName: LCR0161.cs
 * Description: LCR 161. 连续天数的最高销售额
 */

using System;

namespace LCP;

public class LCR0161 {
    public class Solution {
        public int MaxSales(int[] sales) {
            int acc = 0, maximum = sales[0];
            foreach (var num in sales) {
                acc = Math.Max(acc + num, num);
                maximum = Math.Max(maximum, acc);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxSales(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        Console.WriteLine(ans);
    }
}