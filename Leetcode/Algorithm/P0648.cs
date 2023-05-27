/*
 * Author: Deean
 * Date: 2023-05-27 21:32:58
 * FileName: P0648.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0648 {
    public class Solution {
        public string ReplaceWords(IList<string> dictionary, string sentence) {
            IDictionary<string, string> visited = new Dictionary<string, string>();
            string[] dict = dictionary.ToArray();
            Array.Sort(dict, (s1, s2) => s1.Length - s2.Length);
            string[] words = sentence.Split(' ');
            for (int i = 0, n = words.Length; i < n; i++) {
                foreach (var root in dict) {
                    if (visited.ContainsKey(words[i])) {
                        words[i] = visited[words[i]];
                        break;
                    }
                    if (words[i].StartsWith(root)) {
                        words[i] = root;
                        visited[words[i]] = root;
                        break;
                    }
                }
            }
            return string.Join(" ", words);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceWords(new List<string> { "catt", "bat", "rat" }, "the cattle was rattled by the battery");
        Console.WriteLine(ans);
    }
}