/*
 * Author: Deean
 * Date: 2023-03-18 15:05:51
 * FileName: P2574.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2574 {
    public class Solution {
        public int[] LeftRigthDifference(int[] nums) {
            int n = nums.Length;
            int[] left = new int [n], right = new int[n];
            for (int i = 0; i < n - 1; i++) {
                left[i + 1] = left[i] + nums[i];
                right[n - i - 2] = right[n - i - 1] + nums[n - i - 1];
            }
            int[] diff = new int[n];
            for (int i = 0; i < n; i++) {
                diff[i] = Math.Abs(left[i] - right[i]);
            }
            return diff;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LeftRigthDifference(new[] { 10, 4, 8, 3 });
        foreach (var num in ans) {
            Console.WriteLine(num);
        }
    }
}