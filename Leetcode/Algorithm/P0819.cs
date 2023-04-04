/*
 * Author: Deean
 * Date: 2023-04-04 10:15:14
 * FileName: P0819.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithm;

public class P0819 {
    public class Solution {
        public string MostCommonWord(string paragraph, string[] banned) {
            foreach (var c in "!?',;.") {
                paragraph = paragraph.Replace(c.ToString(), " ");
            }
            string[] words =  Regex.Split(paragraph.Trim().ToLower(), @"\s+");
            Console.WriteLine(lib.Arrays.ToString(words));
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words) {
                if (banned.Contains(word)) continue;
                if (!dict.ContainsKey(word)) {
                    dict.Add(word, 0);
                }
                dict[word]++;
            }
            int max = dict.Values.Max();
            foreach (var word in dict.Keys) {
                if (dict[word] == max) {
                    return word;
                }
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" });
        Console.WriteLine(ans);
        ans = s.MostCommonWord("..Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" });
        Console.WriteLine(ans);
    }
}