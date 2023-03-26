/*
 * Author: Deean
 * Date: 2023-03-26 13:50:16
 * FileName: P1684.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1684 {
    public class Solution {
        public int CountConsistentStrings(string allowed, string[] words) {
            int[] hash = new int[26];
            foreach (var c in allowed) {
                hash[c - 'a'] |= 1;
            }
            return words.Count(word => word.All(c => hash[c - 'a'] != 0));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountConsistentStrings("ab", new[] { "ad", "bd", "aaab", "baa", "badab" });
        Console.WriteLine(ans);
    }
}