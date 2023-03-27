/*
 * Author: Deean
 * Date: 2023-03-27 23:41:39
 * FileName: P1539.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1539 {
    public class Solution {
        public int FindKthPositive(int[] arr, int k) {
            int lastMiss = -1, num = 1, pos = 0;
            for (int miss = 0; miss < k; ++num) {
                if (num == arr[pos]) {
                    pos = pos + 1 < arr.Length ? pos + 1 : pos;
                } else {
                    ++miss;
                    lastMiss = num;
                }
            }
            return lastMiss;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindKthPositive(new[] { 2, 3, 4, 7, 11 }, 5);
        Console.WriteLine(ans);
    }
}