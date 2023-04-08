/*
 * Author: Deean
 * Date: 2023-04-08 12:36:37
 * FileName: 剑指 Offer II 018. 有效的回文.cs
 * Description:
*/

using System;
using System.Text;

namespace Sword;

public class 剑指_Offer_II_018__有效的回文 {
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