/*
 * Author: Deean
 * Date: 2023-04-04 10:48:06
 * FileName: P0806.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0806 {
    public class Solution {
        public int[] NumberOfLines(int[] widths, string s) {
            int row = 1, col = 0;
            foreach (var c in s) {
                int need = widths[c - 'a'];
                col += need;
                if (col > 100) {
                    row++;
                    col = need;
                }
            }
            return new[] { row, col };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfLines(
            new[] {
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
            }, "abcdefghijklmnopqrstuvwxyz");
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}