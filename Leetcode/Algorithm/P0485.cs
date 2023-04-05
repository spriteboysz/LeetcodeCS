/*
 * Author: Deean
 * Date: 2023-04-04 21:45:04
 * FileName: P0485.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0485 {
    public class Solution {
        public int FindMaxConsecutiveOnes(int[] nums) {
            int maximum = 0, cnt = 0;
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (nums[i] == 1) {
                    cnt++;
                    maximum = Math.Max(maximum, cnt);
                } else {
                    cnt = 0;
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 });
        Console.WriteLine(ans);
    }
}