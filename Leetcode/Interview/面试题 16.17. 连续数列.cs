/*
 * Author: Deean
 * Date: 2023-04-08 22:23:22
 * FileName: 面试题 16.17. 连续数列.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_16_17__连续数列 {
    public class Solution {
        public int MaxSubArray(int[] nums) {
            int sum = 0, maximum = nums[0];
            foreach (var num in nums) {
                sum = Math.Max(sum + num, num);
                maximum = Math.Max(maximum, sum);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        Console.WriteLine(ans);
    }
}