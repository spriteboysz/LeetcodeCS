/*
 * Author: Deean
 * Date: 2023-03-26 23:15:46
 * FileName: P1437.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1437 {
    public class Solution {
        public bool KLengthApart(int[] nums, int k) {
            int n = 0, m = -1;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1) {
                    n = m;
                    m = i;
                }
                if (n >= 0 && m > n && m - n <= k) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KLengthApart(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2);
        Console.WriteLine(ans);
    }
}