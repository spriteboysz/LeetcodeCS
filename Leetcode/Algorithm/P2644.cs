/*
 * Author: Deean
 * Date: 2023-05-20 14:50:51
 * FileName: P2644.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2644 {
    public class Solution {
        public int MaxDivScore(int[] nums, int[] divisors) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var num in divisors) {
                set.Add(num);
            }
            int max_index = -1, max_value = -1;
            foreach (var num in set) {
                int val = 0;
                foreach (var kv in dict) {
                    if (kv.Key % num == 0) {
                        val += kv.Value;
                    }
                }
                if (val > max_value || (val == max_value && num < max_index)) {
                    max_value = val;
                    max_index = num;
                }
            }
            return max_index;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDivScore(new[] { 4, 7, 9, 3, 9 }, new[] { 5, 2, 3 });
        Console.WriteLine(ans);
    }
}