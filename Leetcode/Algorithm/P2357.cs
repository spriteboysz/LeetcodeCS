/*
 * Author: Deean
 * Date: 2023-03-19 09:36:20
 * FileName: P2357.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2357 {
    public class Solution {
        public int MinimumOperations(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums) {
                if (num != 0) {
                    set.Add(num);
                }
            }
            return set.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumOperations(new[] { 1, 5, 0, 3, 5 });
        Console.WriteLine(ans);
    }
}