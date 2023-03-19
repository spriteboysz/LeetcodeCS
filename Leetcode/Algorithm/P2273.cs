/*
 * Author: Deean
 * Date: 2023-03-19 11:34:41
 * FileName: P2273.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P2273 {
    public class Solution {
        public string Process(string s) {
            int[] hash = new int[26];
            foreach (var c in s) {
                hash[c - 'a']++;
            }
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < 26; i++) {
                ss.Append(hash[i]);
                ss.Append('#');
            }
            return ss.ToString();
        }

        public IList<string> RemoveAnagrams(string[] words) {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var word in words) {
                if (!dict.ContainsKey(word)) {
                    dict.Add(word, Process(word));
                }
            }
            IList<string> stack = new List<string>();
            foreach (var word in words) {
                if (stack.Count == 0 || !string.Equals(dict[stack[stack.Count - 1]], dict[word])) {
                    stack.Add(word);
                }
            }
            return stack;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveAnagrams(new[] { "abba", "baba", "bbaa", "cd", "cd" });
        Console.WriteLine(ans);
    }
}