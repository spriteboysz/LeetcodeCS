/*
 * Author: Deean
 * Date: 2023-10-23 22:35:32
 * FileName: LCR0060.cs
 * Description: LCR 060. 前 K 个高频元素
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0060 {
    public class Solution {
        public int[] TopKFrequent(int[] nums, int k) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict[num] = 0;
                }
                dict[num] += 1;
            }
            int[] keys = dict.Keys.ToArray();
            Array.Sort(keys, (a, b) => dict[b] - dict[a]);
            IList<int> top = new List<int>();
            for (int i = 0; i < k; i++) {
                top.Add(keys[i]);
            }
            return top.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);
        Console.WriteLine(Arrays.ToString(ans));
    }
}