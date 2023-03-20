/*
 * Author: Deean
 * Date: 2023-03-19 19:45:28
 * FileName: P2016.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2016 {
    public class Solution {
        public int MaximumDifference(int[] nums) {
            int maximum = -1, n = nums.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (nums[j] > nums[i]) {
                        maximum = Math.Max(maximum, nums[j] - nums[i]);
                    }
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumDifference(new[] { 1, 5, 2, 10 });
        Console.WriteLine(ans);
    }
}