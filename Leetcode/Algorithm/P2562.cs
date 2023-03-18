/*
 * Author: Deean
 * Date: 2023-03-18 15:38:25
 * FileName: P2562.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2562 {
    public class Solution {
        public long FindTheArrayConcVal(int[] nums) {
            long sum = 0;
            int n = nums.Length;
            for (int i = 0; i < n / 2; i++) {
                int p = nums[n - 1 - i].ToString().Length;
                sum += nums[i] * (long) Math.Pow(10, p) + nums[n - 1 - i];
            }
            if (n % 2 == 1) {
                sum += nums[n / 2];
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTheArrayConcVal(new[] { 5, 14, 13, 8, 12 });
        Console.WriteLine(ans);
    }
}