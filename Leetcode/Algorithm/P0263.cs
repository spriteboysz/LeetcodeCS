/*
 * Author: Deean
 * Date: 2023-04-06 23:56:31
 * FileName: P0263.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0263 {
    public class Solution {
        public bool IsUgly(int n) {
            if (n == 0) return false;
            foreach (var factor in new[] { 5, 3, 2 }) {
                while (n % factor == 0) {
                    n /= factor;
                }
            }
            return n == 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsUgly(6);
        Console.WriteLine(ans);
    }
}