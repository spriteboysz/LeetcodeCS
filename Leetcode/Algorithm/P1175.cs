/*
 * Author: Deean
 * Date: 2023-04-01 22:01:24
 * FileName: P1175.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1175 {
    public class Solution {
        const int MOD = 1000000007;

        private bool IsPrime(int num) {
            if (num == 1) return false;
            for (int i = 2; i * i <= num; i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }

        private long Factorial(int num) {
            long product = 1L;
            for (int i = 1; i <= num; i++) {
                product *= i;
                product %= MOD;
            }
            return product;
        }

        public int NumPrimeArrangements(int n) {
            int cnt = 0;
            for (int i = 1; i <= n; i++) {
                if (IsPrime(i)) {
                    cnt++;
                }
            }
            return (int)(Factorial(cnt) * Factorial(n - cnt) % MOD);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumPrimeArrangements(100);
        Console.WriteLine(ans);
    }
}