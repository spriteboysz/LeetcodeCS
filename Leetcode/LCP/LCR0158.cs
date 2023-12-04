/*
 * Author: Deean
 * Date: 2023-12-04 22:46:41
 * FileName: LCR0158.cs
 * Description: LCR 158. 库存管理 II
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0158 {
    public class Solution {
        public int InventoryManagement(int[] stock) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in stock) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                if (++dict[num] > stock.Length / 2) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InventoryManagement(new[] { 6, 1, 3, 1, 1, 1 });
        Console.WriteLine(ans);
    }
}