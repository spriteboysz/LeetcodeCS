/*
 * Author: Deean
 * Date: 2023-03-23 22:46:11
 * FileName: P1952.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1952 {
    public class Solution {
        public bool IsThree(int n) {
            if (n == 1) return false;
            int sqrt = (int)Math.Sqrt(n);
            if (sqrt * sqrt != n) return false;
            while (sqrt < n - 1) {
                ++sqrt;
                if (n % sqrt == 0) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsThree(4);
        Console.WriteLine(ans);
    }
}