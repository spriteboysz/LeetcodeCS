/*
 * Author: Deean
 * Date: 2023-12-27 21:35:00
 * FileName: LCR0191.cs
 * Description: LCR 191. 按规则计算统计结果
 */

using System;

namespace LCP;

public class LCR0191 {
    public class Solution {
        public int[] StatisticalResult(int[] nums) {
            int n = nums.Length;
            if (n == 0) return new int[0];
            int[] left = new int[n], right = new int[n], arr = new int[n];
            left[0] = 1;
            for (int i = 1; i < n; i++) {
                left[i] = left[i - 1] * nums[i - 1];
            }
            right[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--) {
                right[i] = right[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < n; i++) {
                arr[i] = left[i] * right[i];
            }
            return arr;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.StatisticalResult(new[] { 2, 4, 6, 8, 10 });
        Console.WriteLine(ans);
    }
}