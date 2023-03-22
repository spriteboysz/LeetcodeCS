/*
 * Author: Deean
 * Date: 2023-03-21 23:40:55
 * FileName: P2190.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2190 {
    public class Solution {
        public int MostFrequent(int[] nums, int key) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i - 1] != key) continue;
                if (dict.ContainsKey(nums[i])) {
                    dict[nums[i]] += 1;
                } else {
                    dict.Add(nums[i], 1);
                }
            }
            int maximum = dict.Values.Max();
            foreach (var pair in dict.Where(pair => pair.Value == maximum)) {
                return pair.Key;
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MostFrequent(new[] { 1, 100, 200, 1, 100 }, 1);
        Console.WriteLine(ans);
    }
}