/*
 * Author: Deean
 * Date: 2023-04-03 23:09:56
 * FileName: P0917.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm;

public class P0917 {
    public class Solution {
        public string ReverseOnlyLetters(string s) {
            IList<char> value = s.Where(char.IsLetter).ToList();
            value = value.Reverse().ToList();
            StringBuilder ss = new StringBuilder();
            for (int i = 0, pos = 0; i < s.Length; i++) {
                if (!char.IsLetter(s[i])) {
                    ss.Append(s[i]);
                } else {
                    ss.Append(value[pos++]);
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseOnlyLetters("Test1ng-Leet=code-Q!");
        Console.WriteLine(ans);
    }
}