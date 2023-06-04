/*
 * Author: Deean
 * Date: 2023-06-03 21:41:12
 * FileName: P0096.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0096 {
    public class Solution {
        public int NumTrees(int n) {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            for (int i = 1; i <= n; i++) {
                for (int j = 0; j < i; j++) {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }
            return dp.Last();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumTrees(3);
        Console.WriteLine(ans);
    }
}