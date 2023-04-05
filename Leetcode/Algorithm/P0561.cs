/*
 * Author: Deean
 * Date: 2023-04-05 16:57:18
 * FileName: P0561.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0561 {
    public class Solution {
        public int ArrayPairSum(int[] nums) {
            Array.Sort(nums, (a, b) => b - a);
            int sum = 0;
            for (int i = 1, n = nums.Length; i < n; i += 2) {
                sum += nums[i];
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ArrayPairSum(new[] { 6, 2, 6, 5, 1, 2 });
        Console.WriteLine(ans);
    }
}