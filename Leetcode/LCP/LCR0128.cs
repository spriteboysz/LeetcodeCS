/*
 * Author: Deean
 * Date: 2023-11-16 22:50:37
 * FileName: LCR0128.cs
 * Description: LCR 128. 库存管理 I
 */

using System;

namespace LCP;

public class LCR0128 {
    public class Solution {
        public int StockManagement(int[] stock) {
            int minimum = stock[0];
            for (int i = 1, n = stock.Length; i < n; i++) {
                minimum = Math.Min(minimum, stock[i]);
            }
            return minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.StockManagement(new [] { 4, 5, 8, 3, 4 });
        Console.WriteLine(ans);
    }
}