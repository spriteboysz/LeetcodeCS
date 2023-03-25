/*
 * Author: Deean
 * Date: 2023-03-24 22:12:18
 * FileName: P1876.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1876 {
    public class Solution {
        private bool Check(string sub) {
            char a = sub[0], b = sub[1], c = sub[2];
            return a != b && a != c && b != c;
        }

        public int CountGoodSubstrings(string s) {
            int cnt = 0;
            for (int i = 0; i + 3 <= s.Length; i++) {
                if (Check(s.Substring(i, 3))) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountGoodSubstrings("aababcabc");
        Console.WriteLine(ans);
    }
}