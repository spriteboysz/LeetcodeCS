/*
 * Author: Deean
 * Date: 2023-04-04 12:40:01
 * FileName: P0628.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0628 {
    public class Solution {
        public int MaximumProduct(int[] nums) {
            Array.Sort(nums);
            int n = nums.Length;
            return Math.Max(nums[n - 3] * nums[n - 2] * nums[n - 1], nums[0] * nums[1] * nums[n - 1]);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumProduct(new[] { 1, 2, 3, 4 });
        Console.WriteLine(ans);
    }
}