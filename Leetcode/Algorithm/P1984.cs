/*
 * Author: Deean
 * Date: 2023-03-22 23:08:03
 * FileName: P1984.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1984 {
    public class Solution {
        public int MinimumDifference(int[] nums, int k) {
            Array.Sort(nums);
            int minimum = Int32.MaxValue;
            for (int i = 0; i + k - 1 < nums.Length; i++) {
                minimum = Math.Min(minimum, nums[i + k - 1] - nums[i]);
            }
            return minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumDifference(new[] { 9, 4, 1, 7 }, 2);
        Console.WriteLine(ans);
    }
}