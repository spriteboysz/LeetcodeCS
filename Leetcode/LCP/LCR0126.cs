/*
 * Author: Deean
 * Date: 2023-11-14 22:46:49
 * FileName: LCR00126.cs
 * Description: LCR 126. 斐波那契数
 */

using System;

namespace LCP;

public class LCR0126 {
    public class Solution {
        public int Fib(int n) {
            const int MOD = 1000000007;
            if (n <= 1) return n;
            int p = 0, q = 0, r = 1;
            for (int i = 2; i <= n; i++) {
                p = q;
                q = r;
                r = (p + q) % MOD;
            }
            return r;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Fib(2);
        Console.WriteLine(ans);
    }
}