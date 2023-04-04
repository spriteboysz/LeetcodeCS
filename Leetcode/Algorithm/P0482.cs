/*
 * Author: Deean
 * Date: 2023-04-04 20:11:10
 * FileName: P0482.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P0482 {
    public class Solution {
        public string LicenseKeyFormatting(string s, int k) {
            StringBuilder ss = new StringBuilder();
            int cnt = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] != '-') {
                    cnt++;
                    ss.Append(char.ToUpper(s[i]));
                    if (cnt % k == 0) {
                        ss.Append("-");
                    }
                }
            }
            if (ss.Length > 0 && ss[ss.Length - 1] == '-') {
                ss.Remove(ss.Length - 1, 1);
            }
            char[] cs = ss.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LicenseKeyFormatting("5F3Z-2e-9-w", 4);
        Console.WriteLine(ans);
    }
}