/*
 * Author: Deean
 * Date: 2023-03-26 23:21:52
 * FileName: P1446.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1446 {
    public class Solution {
        public int MaxPower(string s) {
            int maximum = 1, cnt = 1;
            for (int i = 1; i < s.Length; i++) {
                if (s[i] == s[i - 1]) {
                    cnt++;
                    maximum = Math.Max(maximum, cnt);
                } else {
                    cnt = 1;
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxPower("abbcccddddeeeeedcba");
        Console.WriteLine(ans);
    }
}