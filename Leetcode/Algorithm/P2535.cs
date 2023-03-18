/*
 * Author: Deean
 * Date: 2023-03-18 13:48:12
 * FileName: P2535.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2535 {
    public class Solution {
        public int DifferenceOfSum(int[] nums) {
            int sum1 = 0, sum2 = 0;
            foreach (int num in nums) {
                sum1 += num;
                int n = num;
                while (n > 0) {
                    sum2 += n % 10;
                    n /= 10;
                }
            }
            return Math.Abs(sum1 - sum2);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DifferenceOfSum(new[] { 1, 15, 6, 3 });
        Console.WriteLine(ans);
    }
}