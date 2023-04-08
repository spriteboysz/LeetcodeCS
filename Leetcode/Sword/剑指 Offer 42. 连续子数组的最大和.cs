/*
 * Author: Deean
 * Date: 2023-04-08 16:01:55
 * FileName: 剑指 Offer 42. 连续子数组的最大和.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_42__连续子数组的最大和 {
    public class Solution {
        public int MaxSubArray(int[] nums) {
            int acc = 0, maximum = nums[0];
            foreach (var num in nums) {
                acc = Math.Max(acc + num, num);
                maximum = Math.Max(maximum, acc);
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