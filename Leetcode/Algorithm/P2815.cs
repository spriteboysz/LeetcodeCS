/*
 * Author: Deean
 * Date: 2023-08-15 23:39:11
 * FileName: P2815.cs
 * Description:2815. 数组中的最大数对和
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2815 {
    public class Solution {
        public int MaxSum(int[] nums) {
            IDictionary<char, List<int>> hash = new Dictionary<char, List<int>>();
            foreach (var num in nums) {
                char c = num.ToString().ToCharArray().Max();
                if (!hash.ContainsKey(c)) {
                    hash[c] = new List<int>();
                }
                hash[c].Add(num);
            }
            int maximum = -1;
            foreach (var v in hash.Values) {
                if (v.Count < 2) continue;
                v.Sort((a, b) => b - a);
                maximum = Math.Max(maximum, v[0] + v[1]);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxSum(new[] { 51, 71, 17, 24, 42 });
        Console.WriteLine(ans);
        ans = s.MaxSum(new[] { 84, 91, 18, 59, 27, 9, 81, 33, 17, 58 });
        Console.WriteLine(ans);
    }
}