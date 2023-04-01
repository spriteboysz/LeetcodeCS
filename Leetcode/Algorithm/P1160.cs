/*
 * Author: Deean
 * Date: 2023-04-01 21:38:16
 * FileName: P1160.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1160 {
    public class Solution {
        public int CountCharacters(string[] words, string chars) {
            int[] hash = new int[26];
            foreach (var c in chars) {
                hash[c - 'a']++;
            }
            int cnt = 0;
            foreach (var word in words) {
                int[] alphabet = new int[26];
                foreach (var c in word) {
                    alphabet[c - 'a']++;
                }
                bool flag = true;
                for (int i = 0; i < 26; i++) {
                    if (alphabet[i] > hash[i]) {
                        flag = false;
                        break;
                    }
                }
                if (flag) cnt += word.Length;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountCharacters(new[] { "cat", "bt", "hat", "tree" }, "atach");
        Console.WriteLine(ans);
    }
}