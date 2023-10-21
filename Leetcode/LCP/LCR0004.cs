/*
 * Author: Deean
 * Date: 2023-10-20 22:45:54
 * FileName: LCR0004.cs
 * Description: LCR 004. 只出现一次的数字 II
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0004 {
    public class Solution {
        public int SingleNumber(int[] nums) {
            IDictionary<int, int> hash = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!hash.ContainsKey(num)) {
                    hash[num] = 0;
                }
                hash[num]++;
            }
            foreach (var kv in hash) {
                if (kv.Value == 1) {
                    return kv.Key;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNumber(new[] { 0, 1, 0, 1, 0, 1, 100 });
        Console.WriteLine(ans);
    }
}