/*
 * Author: Deean
 * Date: 2023-03-26 23:38:11
 * FileName: P1470.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1470 {
    public class Solution {
        public int[] Shuffle(int[] nums, int n) {
            int[] nums2 = new int[2 * n];
            for (int i = 0; i < n; i++) {
                nums2[2 * i] = nums[i];
                nums2[2 * i + 1] = nums[i + n];
            }
            return nums2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Shuffle(new[] { 2, 5, 1, 3, 4, 7 }, 3);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}