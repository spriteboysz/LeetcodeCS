/*
 * Author: Deean
 * Date: 2023-04-02 19:56:38
 * FileName: P0961.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0961 {
    public class Solution {
        public int RepeatedNTimes(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = nums.Length;
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
                if (dict[num] == n / 2) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RepeatedNTimes(new[] { 2, 1, 2, 5, 3, 2 });
        Console.WriteLine(ans);
    }
}