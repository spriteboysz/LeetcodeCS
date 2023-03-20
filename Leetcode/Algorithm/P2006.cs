/*
 * Author: Deean
 * Date: 2023-03-19 19:39:54
 * FileName: P2006.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2006 {
    public class Solution {
        public int CountKDifference(int[] nums, int k) {
            int cnt = 0, n = nums.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (Math.Abs(nums[i] - nums[j]) == k) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountKDifference(new[] { 1, 2, 2, 1 }, 1);
        Console.WriteLine(ans);
    }
}