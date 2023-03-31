/*
 * Author: Deean
 * Date: 2023-03-31 21:40:06
 * FileName: P1309.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1309 {
    public class Solution {
        public string FreqAlphabets(string s) {
            int n = s.Length;
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < n; i++) {
                if (i + 2 < n && s[i + 2] == '#') {
                    ss.Append((char)((s[i] - '0') * 10 + s[i + 1] - '0' - 1 + 'a'));
                    i += 2;
                } else {
                    ss.Append((char)(s[i] - '0' - 1 + 'a'));
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FreqAlphabets("1326#");
        Console.WriteLine(ans);
    }
}