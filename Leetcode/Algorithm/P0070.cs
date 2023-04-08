/*
 * Author: Deean
 * Date: 2023-04-08 10:37:10
 * FileName: P0070.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0070 {
    public class Solution {
        public int ClimbStairs(int n) {
            if (n <= 2) return n;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++) {
                dp[i] = dp[i - 2] + dp[i - 1];
            }
            return dp[n];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ClimbStairs(3);
        Console.WriteLine(ans);
    }
}