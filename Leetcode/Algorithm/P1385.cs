/*
 * Author: Deean
 * Date: 2023-03-29 23:51:51
 * FileName: P1385.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1385 {
    public class Solution {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
            int value = arr1.Length;
            foreach (var num1 in arr1) {
                if (arr2.Any(num2 => Math.Abs(num1 - num2) <= d)) {
                    value--;
                }
            }
            return value;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTheDistanceValue(new[] { 4, 5, 8 }, new[] { 10, 9, 1, 8 }, 2);
        Console.WriteLine(ans);
    }
}