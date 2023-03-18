/*
 * Author: Deean
 * Date: 2023-03-18 17:22:22
 * FileName: P2506.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P2506 {
    public class Solution {
        public string Process(string s) {
            int[] alphabet = new int[26];
            foreach (var c in s) {
                alphabet[c - 'a']++;
            }
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < 26; i++) {
                if (alphabet[i] > 0) {
                    ss.Append((char) (i + 'a'));
                }
            }
            return ss.ToString();
        }

        public int SimilarPairs(string[] words) {
            for (int i = 0; i < words.Length; i++) {
                words[i] = Process(words[i]);
            }
            int cnt = 0;
            for (int i = 0; i < words.Length; i++) {
                for (int j = i + 1; j < words.Length; j++) {
                    if (string.Equals(words[i], words[j])) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SimilarPairs(new[] { "aba", "aabb", "abcd", "bac", "aabc" });
        Console.WriteLine(ans);
    }
}