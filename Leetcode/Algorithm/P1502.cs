/*
 * Author: Deean
 * Date: 2023-03-27 23:01:53
 * FileName: P1502.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1502 {
    public class Solution {
        public bool CanMakeArithmeticProgression(int[] arr) {
            int n = arr.Length;
            if (n == 2) return true;
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for (int i = 2; i < n; i++) {
                if (arr[i] - arr[i - 1] != diff) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanMakeArithmeticProgression(new[] { 3, 5, 1 });
        Console.WriteLine(ans);
    }
}