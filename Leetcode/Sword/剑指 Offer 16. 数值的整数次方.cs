/*
 * Author: Deean
 * Date: 2023-05-20 16:38:44
 * FileName: 剑指 Offer 16. 数值的整数次方.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_16__数值的整数次方 {
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
        var ans = s.MyPow(2.1, 3);
        Console.WriteLine(ans);
    }
}