/*
 * Author: Deean
 * Date: 2023-03-18 16:04:36
 * FileName: P2553.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P2553 {
    public class Solution {
        public int[] SeparateDigits(int[] nums) {
            StringBuilder s = new StringBuilder();
            foreach (var num in nums) {
                s.Append(num);
            }
            int n = s.Length;
            int[] digits = new int [n];
            for (int i = 0; i < n; i++) {
                digits[i] = s[i] - '0';
            }
            return digits;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SeparateDigits(new[] { 13, 25, 83, 77 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}