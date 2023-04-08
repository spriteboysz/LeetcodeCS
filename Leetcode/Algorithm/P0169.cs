/*
 * Author: Deean
 * Date: 2023-04-08 08:58:33
 * FileName: P0169.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0169 {
    public class Solution {
        public int MajorityElement(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                if (++dict[num] > nums.Length / 2) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MajorityElement(new[] { 2, 2, 1, 1, 1, 2, 2 });
        Console.WriteLine(ans);
    }
}