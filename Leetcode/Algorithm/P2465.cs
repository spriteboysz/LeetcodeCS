/*
 * Author: Deean
 * Date: 2023-03-18 19:25:16
 * FileName: P2465.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2465 {
    public class Solution {
        public int DistinctAverages(int[] nums) {
            Array.Sort(nums);
            int n = nums.Length;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n / 2; i++) {
                set.Add(nums[i] + nums[n - 1 - i]);
            }
            return set.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistinctAverages(new[] { 4, 1, 4, 0, 3, 5 });
        Console.WriteLine(ans);
    }
}