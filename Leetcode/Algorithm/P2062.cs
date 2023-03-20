/*
 * Author: Deean
 * Date: 2023-03-19 22:02:55
 * FileName: P2062.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2062 {
    public class Solution {
        private bool isVowel(char c) {
            return "aeiou".Contains(c.ToString());
        }

        public int CountVowelSubstrings(string word) {
            HashSet<char> set = new HashSet<char>();
            int cnt = 0;
            for (int i = 0; i + 5 <= word.Length; i++) {
                set.Clear();
                if (!isVowel(word[i])) continue;
                for (int j = i; j < word.Length; j++) {
                    if (!isVowel(word[j])) break;
                    set.Add(word[j]);
                    if (set.Count == 5) cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountVowelSubstrings("aeiouu");
        Console.WriteLine(ans);
    }
}