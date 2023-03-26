/*
 * Author: Deean
 * Date: 2023-03-26 10:34:38
 * FileName: P1636.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1636 {
    public class Solution {
        public int[] FrequencySort(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
            }
            Array.Sort(nums, (a, b) =>
                dict[a] == dict[b] ? b - a : dict[a] - dict[b]
            );
            return nums;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FrequencySort(new[] { 1, 1, 2, 2, 2, 3 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}