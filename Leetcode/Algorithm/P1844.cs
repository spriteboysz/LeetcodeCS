/*
 * Author: Deean
 * Date: 2023-03-25 21:33:40
 * FileName: P1844.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1844 {
    public class Solution {
        public string ReplaceDigits(string s) {
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s.Length; i++) {
                if (i % 2 == 0) {
                    ss.Append(s[i]);
                } else {
                    ss.Append((char)(s[i - 1] + s[i] - '0'));
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceDigits("a1b2c3d4e");
        Console.WriteLine(ans);
    }
}