/*
 * Author: Deean
 * Date: 2023-04-09 09:55:24
 * FileName: 面试题 16.11. 跳水板.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_16_11__跳水板 {
    public class Solution {
        public int[] DivingBoard(int shorter, int longer, int k) {
            if (k == 0) return new int[0];
            if (shorter == longer) return new[] { shorter * k };
            int[] lengths = new int[k + 1];
            for (int i = 0; i <= k; i++) {
                lengths[i] = shorter * (k - i) + longer * i;
            }
            return lengths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DivingBoard(1, 2, 3);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}