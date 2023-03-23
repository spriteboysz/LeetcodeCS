/*
 * Author: Deean
 * Date: 2023-03-23 23:34:05
 * FileName: P1920.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1920 {
    public class Solution {
        public int[] BuildArray(int[] nums) {
            int[] nums2 = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) {
                nums2[i] = nums[nums[i]];
            } 
            return nums2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BuildArray(new[] { 0, 2, 1, 5, 3, 4 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}