/*
 * Author: Deean
 * Date: 2023-04-08 17:22:59
 * FileName: 剑指 Offer II 019. 最多删除一个字符得到回文.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_019__最多删除一个字符得到回文 {
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
        var ans = s.ValidPalindrome("abca");
        Console.WriteLine(ans);
    }
}