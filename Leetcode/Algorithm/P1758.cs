/*
 * Author: Deean
 * Date: 2023-03-26 22:41:56
 * FileName: P1758.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1758 {
    public class Solution {
        public int MinOperations(string s) {
            int cnt = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != (char)('0' + i % 2)) {
                    cnt++;
                }
            }
            return Math.Min(cnt, s.Length - cnt);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinOperations("0100");
        Console.WriteLine(ans);
    }
}