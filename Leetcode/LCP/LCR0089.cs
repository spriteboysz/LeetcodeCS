/*
 * Author: Deean
 * Date: 2023-11-07 22:48:43
 * FileName: LCR0089.cs
 * Description: LCR 089. 打家劫舍
 */

using System;

namespace LCP;

public class LCR0089 {
    public class Solution {
        public int Rob(int[] nums) {
            int n = nums.Length;
            if (n == 1) return nums[0];
            int[] dp = new int[n];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; i++) {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            return dp[n - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Rob(new[] { 1, 2, 3, 1 });
        Console.WriteLine(ans);
    }
}