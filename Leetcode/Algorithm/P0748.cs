/*
 * Author: Deean
 * Date: 2023-04-04 11:26:14
 * FileName: P0748.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0748 {
    public class Solution {
        public string ShortestCompletingWord(string licensePlate, string[] words) {
            int[] hash = new int[26];
            foreach (var c in licensePlate) {
                if (char.IsLetter(c)) {
                    hash[char.ToLower(c) - 'a']++;
                }
            }
            
            int idx = -1;
            for (int i = 0; i < words.Length; i++) {
                int[] hash1 = new int[26];
                foreach (var c in words[i]) {
                    hash1[c - 'a']++;
                }
                bool flag = true;
                for (int j = 0; j < 26; j++) {
                    if (hash[j] > 0 && hash1[j] < hash[j]) {
                        flag = false;
                        break;
                    }
                }
                if (flag && (idx < 0 || words[i].Length < words[idx].Length)) {
                    idx = i;
                }
            }
            return words[idx];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ShortestCompletingWord("1s3 456", new[] { "looks", "pest", "stew", "show" });
        Console.WriteLine(ans);
    }
}