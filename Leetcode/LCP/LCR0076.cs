/*
 * Author: Deean
 * Date: 2023-10-26 00:00:56
 * FileName: LCR0076.cs
 * Description: LCR 076. 数组中的第 K 个最大元素
 */

using System;

namespace LCP;

public class LCR0076 {
    public class Solution {
        public int FindKthLargest(int[] nums, int k) {
            Array.Sort(nums, (a, b) => b - a);
            return nums[k - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindKthLargest(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
        Console.WriteLine(ans);
    }
}