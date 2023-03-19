/*
 * Author: Deean
 * Date: 2023-03-19 12:56:35
 * FileName: P2255.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2255 {
    public class Solution {
        public int CountPrefixes(string[] words, string s) {
            int cnt = 0;
            foreach (var word in words) {
                if (word.Length <= s.Length && word == s.Substring(0, word.Length)) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountPrefixes(new[] { "a", "b", "c", "ab", "bc", "abc" }, "abc");
        Console.WriteLine(ans);
    }
}