/*
 * Author: Deean
 * Date: 2023-10-25 00:02:08
 * FileName: LCR0070.cs
 * Description: LCR 070. 有序数组中的单一元素
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0070 {
    public class Solution {
        public int SingleNonDuplicate(int[] nums) {
            IDictionary<int, int> map = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!map.ContainsKey(num)) {
                    map[num] = 0;
                }
                map[num]++;
            }
            foreach (var kv in map) {
                if (kv.Value == 1) {
                    return kv.Key;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNonDuplicate(new[] { 3, 3, 7, 7, 10, 11, 11 });
        Console.WriteLine(ans);
    }
}