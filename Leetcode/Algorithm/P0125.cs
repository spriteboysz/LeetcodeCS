/*
 * Author: Deean
 * Date: 2023-04-08 09:27:23
 * FileName: P0125.cs
 * Description:
*/

using System;
using System.Linq;
using System.Text;

namespace Algorithm;

public class P0125 {
    public class Solution {
        public bool IsPalindrome(string s) {
            StringBuilder ss = new StringBuilder();
            foreach (var c in s.Where(char.IsLetterOrDigit)) {
                ss.Append(char.ToLower(c));
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