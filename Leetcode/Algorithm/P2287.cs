/*
 * Author: Deean
 * Date: 2023-03-19 11:17:26
 * FileName: P2287.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2287 {
    public class Solution {
        public int RearrangeCharacters(string s, string target) {
            int[] hash1 = new int[26], hash2 = new int[26];
            foreach (var c in s) {
                hash1[c - 'a']++;
            }
            foreach (var c in target) {
                hash2[c - 'a']++;
            }

            int cnt = s.Length;
            for (int i = 0; i < 26; i++) {
                if (hash2[i] == 0) continue;
                cnt = Math.Min(cnt, hash1[i] / hash2[i]);
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RearrangeCharacters("ilovecodingonleetcode", "code");
        Console.WriteLine(ans);
    }
}