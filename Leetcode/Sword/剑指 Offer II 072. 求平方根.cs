/*
 * Author: Deean
 * Date: 2023-04-08 19:49:57
 * FileName: 剑指 Offer II 072. 求平方根.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_II_072__求平方根 {
    public class Solution {
        public int MySqrt(int x) {
            if (x == 0) return 0;
            int left = 1, right = x;
            while (left < right) {
                int mid = left + (right - left + 1) / 2;
                if ((long)mid * mid <= x) {
                    left = mid;
                } else {
                    right = mid - 1;
                }
            }
            return left;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MySqrt(8);
        Console.WriteLine(ans);
    }
}