/*
 * Author: Deean
 * Date: 2023-03-19 10:24:22
 * FileName: P2309.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2309 {
    public class Solution {
        public string GreatestLetter(string s) {
            int[] hash = new int[26];
            foreach (var c in s) {
                if (char.IsLower(c)) {
                    hash[c - 'a'] |= 1;
                } else {
                    hash[c - 'A'] |= 2;
                }
            }
            for (int i = 26 - 1; i >= 0; i--) {
                if (hash[i] == 3) {
                    return ((char)(i + 'A')).ToString();
                }
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GreatestLetter("lEeTcOdE");
        Console.WriteLine(ans);
    }
}