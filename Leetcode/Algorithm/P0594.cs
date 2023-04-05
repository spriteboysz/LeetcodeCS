/*
 * Author: Deean
 * Date: 2023-04-05 17:34:58
 * FileName: P0594.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0594 {
    public class Solution {
        public int FindLHS(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            int maximum = 0;
            foreach (var key in dict.Keys) {
                if (dict.ContainsKey(key + 1)) {
                    maximum = Math.Max(maximum, dict[key] + dict[key + 1]);
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindLHS(new[] { 1, 3, 2, 2, 5, 2, 3, 7 });
        Console.WriteLine(ans);
    }
}