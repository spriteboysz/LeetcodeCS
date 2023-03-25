/*
 * Author: Deean
 * Date: 2023-03-24 21:57:53
 * FileName: P1897.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1897 {
    public class Solution {
        public bool MakeEqual(string[] words) {
            int[] alphabet = new int[26];
            int n = words.Length;
            foreach (var word in words) {
                foreach (var c in word) {
                    alphabet[c - 'a']++;
                }
            }
            return alphabet.All(count => count % n == 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MakeEqual(new[] { "abc", "aabc", "bc" });
        Console.WriteLine(ans);
    }
}