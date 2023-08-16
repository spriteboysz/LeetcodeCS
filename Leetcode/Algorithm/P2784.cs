/*
 * Author: Deean
 * Date: 2023-08-16 22:21:47
 * FileName: P2784.cs
 * Description:2784. 检查数组是否是好的
 */

using System;

namespace Algorithm;

public class P2784 {
    public class Solution {
        public bool IsGood(int[] nums) {
            int n = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < n - 1; i++) {
                if (nums[i] != i + 1) {
                    return false;
                }
            }
            return nums[n - 1] == n - 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsGood(new[] { 1, 3, 3, 2 });
        Console.WriteLine(ans);
    }
}