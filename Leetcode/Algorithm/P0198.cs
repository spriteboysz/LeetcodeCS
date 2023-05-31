/*
 * Author: Deean
 * Date: 2023-05-30 23:32:32
 * FileName: P198.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0198 {
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
            return dp.Last();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Rob(new[] { 1, 2, 3, 1 });
        Console.WriteLine(ans);
    }
}