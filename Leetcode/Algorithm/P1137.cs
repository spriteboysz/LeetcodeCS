/*
 * Author: Deean
 * Date: 2023-04-01 21:25:39
 * FileName: P1137.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1137 {
    public class Solution {
        public int Tribonacci(int n) {
            if (n == 0) return 0;
            if (n <= 2) return 1;
            int p = 0, q = 0, r = 1, s = 1;
            for (int i = 3; i <= n; i++) {
                p = q;
                q = r;
                r = s;
                s = p + q + r;
            }
            return s;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Tribonacci(25);
        Console.WriteLine(ans);
    }
}