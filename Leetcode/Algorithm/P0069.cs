/*
 * Author: Deean
 * Date: 2023-04-08 10:39:48
 * FileName: P0069.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0069 {
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