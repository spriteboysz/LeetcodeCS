/*
 * Author: Deean
 * Date: 2023-05-21 10:27:59
 * FileName: 剑指 Offer 62. 圆圈中最后剩下的数字.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_62__圆圈中最后剩下的数字 {
    public class Solution {
        public int LastRemaining(int n, int m) {
            if (n == 1) return 0;
            int prev = LastRemaining(n - 1, m);
            return (prev + m) % n;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LastRemaining(5, 3);
        Console.WriteLine(ans);
    }
}