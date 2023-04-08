/*
 * Author: Deean
 * Date: 2023-04-08 13:15:42
 * FileName: 剑指 Offer 10- I. 斐波那契数列.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_10__I__斐波那契数列 {
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
        var ans = s.Fib(100);
        Console.WriteLine(ans);
    }
}