/*
 * Author: Deean
 * Date: 2023-03-25 21:42:47
 * FileName: P1848.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1848 {
    public class Solution {
        public int GetMinDistance(int[] nums, int target, int start) {
            List<int> list = new List<int>();
            for (var i = 0; i < nums.Length; i++) {
                if (nums[i] == target) {
                    list.Add(i);
                }
            }

            var min = int.MaxValue;
            foreach (var i in list) {
                min = Math.Min(min, Math.Abs(i - start));
            }
            return min;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetMinDistance(new[] { 1, 2, 3, 4, 5 }, 5, 3);
        Console.WriteLine(ans);
    }
}