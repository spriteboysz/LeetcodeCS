/*
 * Author: Deean
 * Date: 2023-03-29 22:27:21
 * FileName: P1588.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1588 {
    public class Solution {
        public int SumOddLengthSubarrays(int[] arr) {
            int sum = 0, n = arr.Length;
            for (int start = 0; start < n; start++) {
                for (int length = 1; start + length <= n; length += 2) {
                    int end = start + length - 1;
                    for (int i = start; i <= end; i++) {
                        sum += arr[i];
                    }
                }
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumOddLengthSubarrays(new[] { 1, 4, 2, 5, 3 });
        Console.WriteLine(ans);
    }
}