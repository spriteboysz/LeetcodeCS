/*
 * Author: Deean
 * Date: 2023-03-27 23:37:10
 * FileName: P1534.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1534 {
    public class Solution {
        public int CountGoodTriplets(int[] arr, int a, int b, int c) {
            int cnt = 0, n = arr.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (Math.Abs(arr[i] - arr[j]) > a) continue;
                    for (int k = j + 1; k < n; k++) {
                        if (Math.Abs(arr[i] - arr[k]) <= c && Math.Abs(arr[j] - arr[k]) <= b) {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountGoodTriplets(new[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3);
        Console.WriteLine(ans);
    }
}