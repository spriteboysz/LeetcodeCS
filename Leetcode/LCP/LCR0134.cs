/*
 * Author: Deean
 * Date: 2023-11-18 21:27:03
 * FileName: LCR0134.cs
 * Description: LCR 134. Pow(x, n)
 */

using System;

namespace LCP;

public class LCR0134 {
    public class Solution {
        public double Process(double x, long n) {
            if (n == 0) return 1.0d;
            double y = Process(x, n / 2);
            return n % 2 == 0 ? y * y : y * y * x;
        }

        public double MyPow(double x, int n) {
            long nn = n;
            return nn > 0 ? Process(x, nn) : 1.0d / Process(x, -nn);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MyPow(2.0, 10);
        Console.WriteLine(ans);
    }
}