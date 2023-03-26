/*
 * Author: Deean
 * Date: 2023-03-26 23:52:55
 * FileName: P1480.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1480 {
    public class Solution {
        public int[] RunningSum(int[] nums) {
            int n = nums.Length, sum = 0;
            int[] running = new int[n];
            for (int i = 0; i < n; i++) {
                sum += nums[i];
                running[i] = sum;
            }
            return running;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RunningSum(new[] { 1, 2, 3, 4 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}