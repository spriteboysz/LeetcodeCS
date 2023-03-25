/*
 * Author: Deean
 * Date: 2023-03-24 23:01:03
 * FileName: P1800.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1800 {
    public class Solution {
        public int MaxAscendingSum(int[] nums) {
            int maximum = 0;
            for (int i = 0; i < nums.Length;) {
                int sum = nums[i++];
                while (i < nums.Length && nums[i] > nums[i - 1]) {
                    sum += nums[i++];
                }
                maximum = Math.Max(maximum, sum);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxAscendingSum(new[] { 10, 20, 30, 5, 10, 50 });
        Console.WriteLine(ans);
    }
}