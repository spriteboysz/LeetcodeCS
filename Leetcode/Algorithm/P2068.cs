/*
 * Author: Deean
 * Date: 2023-03-19 22:18:16
 * FileName: P2068.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2068 {
    public class Solution {
        public bool CheckAlmostEquivalent(string word1, string word2) {
            int[] hash = new int[26];
            foreach (var c in word1) {
                hash[c - 'a']++;
            }
            foreach (var c in word2) {
                hash[c - 'a']--;
            }
            for (int i = 0; i < 26; i++) {
                if (Math.Abs(hash[i]) > 3) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckAlmostEquivalent("abcdeef", "abaaacc");
        Console.WriteLine(ans);
    }
}