/*
 * Author: Deean
 * Date: 2023-03-23 23:29:35
 * FileName: P1925.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1925 {
    public class Solution {
        public int CountTriples(int n) {
            int cnt = 0;
            for (int a = 1; a <= n; a++) {
                for (int b = 1; b <= n; b++) {
                    int c = (int)Math.Sqrt(a * a + b * b);
                    if (c <= n && a * a + b * b == c * c) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountTriples(10);
        Console.WriteLine(ans);
    }
}