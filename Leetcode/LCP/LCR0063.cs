/*
 * Author: Deean
 * Date: 2023-10-23 22:37:51
 * FileName: LCR0063.cs
 * Description: LCR 063. 单词替换
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0063 {
    public class Solution {
        public string ReplaceWords(IList<string> dictionary, string sentence) {
            HashSet<string> set = new HashSet<string>();
            foreach (var word in dictionary) {
                set.Add(word);
            }
            string[] words = sentence.Split(' ');
            for (int i = 0, n = words.Length; i < n; i++) {
                for (int j = 0; j < words[i].Length; j++) {
                    if (set.Contains(words[i].Substring(0, 1 + j))) {
                        words[i] = words[i].Substring(0, 1 + j);
                        break;
                    }
                }
            }
            return string.Join(" ", words);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceWords(new[] { "cat", "bat", "rat" }, "the cattle was rattled by the battery");
        Console.WriteLine(ans);
    }
}