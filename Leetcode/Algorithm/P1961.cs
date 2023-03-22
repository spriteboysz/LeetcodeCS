/*
 * Author: Deean
 * Date: 2023-03-22 23:38:18
 * FileName: P1961.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1961 {
    public class Solution {
        public bool IsPrefixString(string s, string[] words) {
            StringBuilder ss = new StringBuilder();
            foreach (var word in words) {
                ss.Append(word);
                if (Equals(ss.ToString(), s)) {
                    return true;
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPrefixString("iloveleetcode", new[] { "i", "love", "leetcode", "apples" });
        Console.WriteLine(ans);
    }
}