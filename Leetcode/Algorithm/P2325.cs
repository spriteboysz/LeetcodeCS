/*
 * Author: Deean
 * Date: 2023-03-19 10:06:05
 * FileName: P2325.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P2325 {
    public class Solution {
        public string DecodeMessage(string key, string message) {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            int pos = 0;
            dict.Add(' ', ' ');
            foreach (var c in key) {
                if (c != '0' && !dict.ContainsKey(c)) {
                    dict.Add(c, (char)('a' + pos++));
                }
            }

            StringBuilder decode = new StringBuilder();
            foreach (var c in message) {
                decode.Append(dict[c]);
            }
            return decode.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv");
        Console.WriteLine(ans);
    }
}