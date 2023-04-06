/*
 * Author: Deean
 * Date: 2023-04-05 23:16:40
 * FileName: P0367.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0367 {
    public class Solution {
        public bool IsPerfectSquare(int num) {
            int left = 0, right = num;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                long square = (long) mid * mid;
                if (square < num) {
                    left = mid + 1;
                } else if (square > num) {
                    right = mid - 1;
                } else {
                    return true;
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPerfectSquare(16);
        Console.WriteLine(ans);
    }
}