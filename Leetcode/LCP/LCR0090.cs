/*
 * Author: Deean
 * Date: 2023-11-08 20:51:17
 * FileName: LCR0090.cs
 * Description: LCR 090. 打家劫舍 II
 */

using System;
using System.Linq;

namespace LCP;

public class LCR0090 {
    public class Solution {
        public int Rob(int[] nums) {
            int n = nums.Length;
            if (n == 1) return nums[0];
            return Math.Max(Rob(nums, 0, n - 2), Rob(nums, 1, n - 1));
        }

        public int Rob(int[] nums, int start, int end) {
            int m = end - start + 1;
            if (m == 1) return nums[start];
            int[] dp = new int[m];
            dp[0] = nums[start];
            dp[1] = Math.Max(nums[start], nums[start + 1]);
            for (int i = 2; i < m; i++) {
                dp[i] = Math.Max(dp[i - 2] + nums[start + i], dp[i - 1]);
            }
            return dp.Last();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Rob(new[] { 2, 3, 2 });
        Console.WriteLine(ans);
    }
}