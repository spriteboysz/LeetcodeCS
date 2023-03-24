/*
 * Author: Deean
 * Date: 2023-03-23 23:12:12
 * FileName: P1941.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1941 {
    public class Solution {
        public bool AreOccurrencesEqual(string s) {
            int[] alphabet = new int[26];
            foreach (var c in s) {
                alphabet[c - 'a']++;
            }
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 26; i++) {
                if (alphabet[i] != 0) {
                    set.Add(alphabet[i]);
                }
            }
            return set.Count == 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AreOccurrencesEqual("abacbc");
        Console.WriteLine(ans);
    }
}