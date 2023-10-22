/*
 * Author: Deean
 * Date: 2023-10-20 23:45:04
 * FileName: LCR0019.cs
 * Description: LCR 019. 验证回文串 II
 */

using System;

namespace LCP;

public class LCR0019 {
    public class Solution {
        private bool Check(string s) {
            for (int i = 0, n = s.Length; i < n / 2; i++) {
                if (s[i] != s[n - 1 - i]) {
                    return false;
                }
            }
            return true;
        }

        public bool ValidPalindrome(string s) {
            for (int i = 0, n = s.Length; i < n / 2; i++) {
                if (s[i] != s[n - 1 - i]) {
                    return Check(s.Substring(0, i) + s.Substring(i + 1)) ||
                           Check(s.Substring(0, n - 1 - i) + s.Substring(n - i));
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ValidPalindrome("aba");
        Console.WriteLine(ans);
    }
}