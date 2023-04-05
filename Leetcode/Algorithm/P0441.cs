/*
 * Author: Deean
 * Date: 2023-04-05 19:33:17
 * FileName: P0441.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0441 {
    public class Solution {
        public int ArrangeCoins(int n) {
            int left = 1, right = n;
            while (left < right) {
                int mid = (right - left + 1) / 2 + left;
                if ((long) mid * (mid + 1) <= (long) 2 * n) {
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
        var ans = s.ArrangeCoins(8);
        Console.WriteLine(ans);
    }
}