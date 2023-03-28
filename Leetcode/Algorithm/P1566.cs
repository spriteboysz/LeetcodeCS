/*
 * Author: Deean
 * Date: 2023-03-28 23:08:31
 * FileName: P1566.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1566 {
    public class Solution {
        public bool ContainsPattern(int[] arr, int m, int k) {
            int n = arr.Length;
            for (int i = 0; i <= n - m * k; i++) {
                int x1 = i, x2 = i + m;
                while (x2 < i + m * k) {
                    if (arr[x1] != arr[x2]) {
                        break;
                    }
                    x1++;
                    x2++;
                }
                if (x2 == i + m * k) {
                    return true;
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ContainsPattern(new[] { 1, 2, 1, 2, 1, 1, 1, 3 }, 2, 2);
        Console.WriteLine(ans);
    }
}