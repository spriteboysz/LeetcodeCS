/*
 * Author: Deean
 * Date: 2023-04-09 11:43:20
 * FileName: 面试题 08.01. 三步问题.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_08_01__三步问题 {
    public class Solution {
        public int WaysToStep(int n) {
            const int MOD = 1000000007;
            if (n <= 2) return n;
            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 4;
            for (int i = 3; i < n; i++) {
                dp[i] = ((dp[i - 3] + dp[i - 2]) % MOD + dp[i - 1]) % MOD;
            }
            return dp[n - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.WaysToStep(5);
        Console.WriteLine(ans);
    }
}