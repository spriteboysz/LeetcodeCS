/*
 * Author: Deean
 * Date: 2023-11-15 21:56:25
 * FileName: LCR0127.cs
 * Description: LCR 127. 跳跃训练
 */

using System;

namespace LCP;

public class LCR0127 {
    public class Solution {
        public int TrainWays(int n) {
            const int MOD = 1000000007;
            if (n <= 1) return 1;
            int a = 1, b = 1, num = 0;
            for (int i = 2; i <= n; i++) {
                num = (a + b) % MOD;
                a = b;
                b = num;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrainWays(5);
        Console.WriteLine(ans);
    }
}