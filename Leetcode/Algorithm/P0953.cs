/*
 * Author: Deean
 * Date: 2023-04-02 20:13:11
 * FileName: P0953.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0953 {
    public class Solution {
        public bool IsAlienSorted(string[] words, string order) {
            int[] hash = new int[26];
            for (int i = 0; i < order.Length; i++) {
                hash[order[i] - 'a'] = i;
            }
            for (int i = 0; i < words.Length - 1; i++) {
                bool flag = true;
                for (int j = 0; j < Math.Min(words[i].Length, words[i + 1].Length); j++) {
                    if (hash[words[i][j] - 'a'] == hash[words[i + 1][j] - 'a']) {
                        continue;
                    }
                    if (hash[words[i][j] - 'a'] > hash[words[i + 1][j] - 'a']) {
                        return false;
                    } else {
                        flag = false;
                        break;
                    }
                }
                if (words[i].Length > words[i + 1].Length && flag) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsAlienSorted(new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
        Console.WriteLine(ans);
    }
}