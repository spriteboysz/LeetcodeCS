/*
 * Author: Deean
 * Date: 2023-05-26 23:01:45
 * FileName: P0347.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0347 {
    public class Solution {
        public int[] TopKFrequent(int[] nums, int k) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict[num] = 0;
                }
                dict[num]++;
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