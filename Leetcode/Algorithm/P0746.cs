/*
 * Author: Deean
 * Date: 2023-04-04 12:10:14
 * FileName: P0746.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0746 {
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
        var ans = s.MinCostClimbingStairs(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
        Console.WriteLine(ans);
    }
}