/*
 * Author: Deean
 * Date: 2023-05-27 21:24:01
 * FileName: 剑指 Offer II 063. 替换单词.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_063__替换单词 {
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
        var ans = s.ReplaceWords(new List<string> { "cat", "bat", "rat" }, "the cattle was rattled by the battery");
        Console.WriteLine(ans);
    }
}