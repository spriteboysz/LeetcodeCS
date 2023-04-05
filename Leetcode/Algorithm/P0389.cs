/*
 * Author: Deean
 * Date: 2023-04-05 22:48:33
 * FileName: P0389.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0389 {
    public class Solution {
        public char FindTheDifference(string s, string t) {
            int[] hash = new int[26];
            foreach (var c in s) {
                hash[c - 'a']--;
            }
            foreach (var c in t) {
                hash[c - 'a']++;
            }
            for (int i = 0; i < 26; i++) {
                if (hash[i] == 1) {
                    return (char)(i + 'a');
                }
            }
            return '?';
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTheDifference("abcd", "abcde");
        Console.WriteLine(ans);
    }
}