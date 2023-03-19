/*
 * Author: Deean
 * Date: 2023-03-19 10:36:28
 * FileName: P2303.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2303 {
    public class Solution {
        public double CalculateTax(int[][] brackets, int income) {
            int tax = 0, left = 0;
            foreach (var bracket in brackets) {
                if (income > bracket[0]) {
                    tax += (bracket[0] - left) * bracket[1];
                    left = bracket[0];
                } else {
                    tax += (income - left) * bracket[1];
                    break;
                }
            }
            return tax / 100.0;
        }
    }

    public static void Test() {
        int[][] brackets = new int[3][];
        brackets[0] = new[] { 3, 50 };
        brackets[1] = new[] { 7, 10 };
        brackets[2] = new[] { 12, 25 };
        var s = new Solution();
        var ans = s.CalculateTax(brackets, 10);
        Console.WriteLine(ans);
    }
}