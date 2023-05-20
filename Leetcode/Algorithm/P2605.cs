/*
 * Author: Deean
 * Date: 2023-05-19 22:37:50
 * FileName: P2605.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2605 {
    public class Solution {
        public int MinNumber(int[] nums1, int[] nums2) {
            int[] nums = new int[10];
            foreach (var num in nums1) {
                nums[num] |= 1;
            }
            foreach (var num in nums2) {
                nums[num] |= 2;
            }
            int a = 0, b = 0;
            for (int i = 0; i < 10; i++) {
                if (a == 0 && nums[i] == 1) a = i;
                if (b == 0 && nums[i] == 2) b = i;
                if (nums[i] == 3) return i;
            }
            return Math.Min(a * 10 + b, a + b * 10);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinNumber(new[] { 4, 1, 3 }, new[] { 5, 7 });
        Console.WriteLine(ans);
    }
}