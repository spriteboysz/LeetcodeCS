/*
 * Author: Deean
 * Date: 2023-03-21 22:55:54
 * FileName: P2154.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2154 {
    public class Solution {
        public int FindFinalValue(int[] nums, int original) {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums) {
                set.Add(num);
            }
            while (set.Contains(original)) {
                original *= 2;
            }
            return original;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindFinalValue(new[] { 5, 3, 6, 1, 12 }, 3);
        Console.WriteLine(ans);
    }
}