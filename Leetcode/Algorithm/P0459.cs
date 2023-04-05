/*
 * Author: Deean
 * Date: 2023-04-05 19:19:03
 * FileName: P0459.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm; 

public class P0459 {
    public class Solution {
        public bool RepeatedSubstringPattern(string s) {
            int n = s.Length;
            for (int i = 1; i <= n / 2; i++) {
                if (n % i == 0 && IsRepeat(s, i)) {
                    return true;
                }
            }
            return false;
        }

        private bool IsRepeat(string s, int len) {
            string sub = s.Substring(0, len);
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s.Length/len; i++) {
                ss.Append(sub);
            }
            return Equals(s, ss.ToString());
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RepeatedSubstringPattern("abab");
        Console.WriteLine(ans);
    }
}