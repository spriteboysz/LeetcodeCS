/*
 * Author: Deean
 * Date: 2023-08-16 22:30:07
 * FileName: P2778.cs
 * Description:2778. 特殊元素平方和
 */

using System;

namespace Algorithm;

public class P2778 {
    public class Solution {
        public int SumOfSquares(int[] nums) {
            int sum = 0;
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (n % (i + 1) == 0) {
                    sum += nums[i] * nums[i];
                }
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumOfSquares(new[] { 2, 7, 1, 19, 18, 3 });
        Console.WriteLine(ans);
    }
}