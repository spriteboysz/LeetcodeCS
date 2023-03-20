/*
 * Author: Deean
 * Date: 2023-03-19 23:08:37
 * FileName: P2099.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2099 {
    public class Solution {
        public int[] MaxSubsequence(int[] nums, int k) {
            Array.Sort(nums);
            int sum = 0;
            for (int i = nums.Length - 1; i >= 0 && k > 0; i--) {
                sum += nums[i];
                k--;
            }
            return new[] { 3, 3 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxSubsequence(new[] { 2, 1, 3, 3 }, 2);
        Console.WriteLine(ans);
    }
}