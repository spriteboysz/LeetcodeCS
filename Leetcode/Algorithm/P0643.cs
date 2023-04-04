/*
 * Author: Deean
 * Date: 2023-04-04 12:54:30
 * FileName: P0643.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0643 {
    public class Solution {
        public double FindMaxAverage(int[] nums, int k) {
            int n = nums.Length, sum = 0;
            for (int i = 0; i < k; i++) {
                sum += nums[i];
            }
            int maximum = sum;
            for (int i = k; i < n; i++) {
                sum = sum - nums[i - k] + nums[i];
                maximum = Math.Max(maximum, sum);
            }
            return maximum * 1.0 / k;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMaxAverage(new[] { 1, 12, -5, -6, 50, 3 }, 4);
        Console.WriteLine(ans);
    }
}