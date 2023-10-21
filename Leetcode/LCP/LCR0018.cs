/*
 * Author: Deean
 * Date: 2023-10-20 23:41:25
 * FileName: LCR0018.cs
 * Description: LCR 018. 验证回文串
 */

using System;
using System.Text;

namespace LCP;

public class LCR0018 {
    public class Solution {
        public bool IsPalindrome(string s) {
            StringBuilder ss = new StringBuilder();
            foreach (var c in s) {
                if (char.IsLetterOrDigit(c)) {
                    ss.Append(char.ToLower(c));
                }
            }
            for (int i = 0, n = ss.Length; i < n / 2; i++) {
                if (ss[i] != ss[n - 1 - i]) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPalindrome("A man, a plan, a canal: Panama");
        Console.WriteLine(ans);
    }
}