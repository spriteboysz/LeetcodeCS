/*
 * Author: Deean
 * Date: 2023-04-02 22:09:51
 * FileName: P0884.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0884 {
    public class Solution {
        public string[] UncommonFromSentences(string s1, string s2) {
            string[] words1 = s1.Split(' ');
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            foreach (var word in words1) {
                if (!dict1.ContainsKey(word)) {
                    dict1.Add(word, 0);
                }
                dict1[word]++;
            }

            string[] words2 = s2.Split(' ');
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            foreach (var word in words2) {
                if (!dict2.ContainsKey(word)) {
                    dict2.Add(word, 0);
                }
                dict2[word]++;
            }

            List<string> uncommon = new List<string>();
            foreach (var key in dict1.Keys) {
                if (dict1[key] == 1 && !dict2.ContainsKey(key)) {
                    uncommon.Add(key);
                }
            }
            foreach (var key in dict2.Keys) {
                if (dict2[key] == 1 && !dict1.ContainsKey(key)) {
                    uncommon.Add(key);
                }
            }
            return uncommon.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.UncommonFromSentences("this apple is sweet", "this apple is sour");
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}