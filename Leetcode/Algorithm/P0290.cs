/*
 * Author: Deean
 * Date: 2023-04-06 23:30:41
 * FileName: P0290.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0290 {
    public class Solution {
        public bool WordPattern(string pattern, string s) {
            Dictionary<char, string> dict1 = new Dictionary<char, string>();
            Dictionary<string, char> dict2 = new Dictionary<string, char>();
            string[] words = s.Split(' ');
            if (pattern.Length != words.Length) return false;
            for (int i = 0, n = pattern.Length; i < n; i++) {
                char c = pattern[i];
                string word = words[i];
                if (!dict1.ContainsKey(c)) {
                    dict1.Add(c, word);
                } else if (!Equals(dict1[c], word)) {
                    return false;
                }
                if (!dict2.ContainsKey(word)) {
                    dict2.Add(word, c);
                } else if (dict2[word] != c) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.WordPattern("abba", "dog cat cat dog");
        Console.WriteLine(ans);
    }
}