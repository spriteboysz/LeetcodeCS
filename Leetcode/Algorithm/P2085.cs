/*
 * Author: Deean
 * Date: 2023-03-19 22:40:52
 * FileName: P2085.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2085 {
    public class Solution {
        public int CountWords(string[] words1, string[] words2) {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            foreach (var word in words1) {
                if (dict1.ContainsKey(word)) {
                    dict1[word] += 1;
                } else {
                    dict1.Add(word, 1);
                }
            }
            foreach (var word in words2) {
                if (dict2.ContainsKey(word)) {
                    dict2[word] += 1;
                } else {
                    dict2.Add(word, 1);
                }
            }

            int cnt = 0;
            foreach (var word in words1) {
                if (!dict2.ContainsKey(word)) continue;
                if (dict1[word] == 1 && dict2[word] == 1) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountWords(new[] { "leetcode", "is", "amazing", "as", "is" },
            new[] { "amazing", "leetcode", "is" });
        Console.WriteLine(ans);
    }
}