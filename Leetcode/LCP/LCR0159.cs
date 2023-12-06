/*
 * Author: Deean
 * Date: 2023-12-05 22:55:25
 * FileName: LCR0159.cs
 * Description: LCR 159. 库存管理 III
 */

using System;

namespace LCP;

public class LCR0159 {
    public class Solution {
        public int[] InventoryManagement(int[] stock, int cnt) {
            Array.Sort(stock);
            int[] least = new int[cnt];
            for (int i = 0; i < cnt; i++) {
                least[i] = stock[i];
            }
            return least;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InventoryManagement(new[] { 12, 5, 7, 4 }, 1);
        Console.WriteLine(ans);
    }
}