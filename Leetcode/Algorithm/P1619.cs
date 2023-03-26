/*
 * Author: Deean
 * Date: 2023-03-26 10:14:39
 * FileName: P1619.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1619 {
    public class Solution {
        public double TrimMean(int[] arr) {
            Array.Sort(arr, (a, b) => a - b);
            int n = arr.Length, sum = 0;
            for (int i = n * 5 / 100; i < n * 95 / 100; i++) {
                sum += arr[i];
            }
            return sum * 1.0 / (0.9 * n);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrimMean(new[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 });
        Console.WriteLine(ans);
    }
}