/*
 * Author: Deean
 * Date: 2023-03-22 23:13:08
 * FileName: P1979.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1979 {
    public class Solution {
        private int gcd(int a, int b) {
            return b == 0 ? a : gcd(b, a % b);
        }

        public int FindGCD(int[] nums) {
            return gcd(nums.Max(), nums.Min());
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindGCD(new[] { 2, 5, 6, 9, 10 });
        Console.WriteLine(ans);
    }
}