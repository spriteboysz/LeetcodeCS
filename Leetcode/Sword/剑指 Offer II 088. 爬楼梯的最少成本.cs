/*
 * Author: Deean
 * Date: 2023-04-08 20:06:39
 * FileName: 剑指 Offer II 088. 爬楼梯的最少成本.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_088__爬楼梯的最少成本 {
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