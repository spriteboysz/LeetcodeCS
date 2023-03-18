/*
 * Author: Deean
 * Date: 2023-03-18 16:38:49
 * FileName: P2529.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2529 {
    public class Solution {
        public int MaximumCount(int[] nums) {
            int negative = 0, positive = 0;
            foreach (var num in nums) {
                if (num > 0) positive++;
                if (num < 0) negative++;
            }
            return Math.Max(negative, positive);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumCount(new[] { -2, -1, -1, 1, 2, 3 });
        Console.WriteLine(ans);
    }
}