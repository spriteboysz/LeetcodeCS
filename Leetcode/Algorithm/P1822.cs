/*
 * Author: Deean
 * Date: 2023-03-24 23:35:25
 * FileName: P1822.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1822 {
    public class Solution {
        public int ArraySign(int[] nums) {
            int negative = 0;
            foreach (var num in nums) {
                if (num == 0) return 0;
                if (num < 0) negative++;
            }
            return negative % 2 == 0 ? 1 : -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ArraySign(new[] { -1, -2, -3, -4, 3, 2, 1 });
        Console.WriteLine(ans);
    }
}