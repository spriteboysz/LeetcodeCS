/*
 * Author: Deean
 * Date: 2023-11-06 21:47:08
 * FileName: LCR0088.cs
 * Description: LCR 088. 使用最小花费爬楼梯
 */

using System;

namespace LCP;

public class LCR0088 {
    public class Solution {
        public int MinCostClimbingStairs(int[] cost) {
            int n = cost.Length;
            int[] dp = new int[n + 1];
            dp[0] = dp[1] = 0;
            for (int i = 2; i <= n; i++) {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }
            return dp[n];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinCostClimbingStairs(new[] { 10, 15, 20 });
        Console.WriteLine(ans);
    }
}