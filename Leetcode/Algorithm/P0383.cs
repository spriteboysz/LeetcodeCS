/*
 * Author: Deean
 * Date: 2023-04-05 22:57:09
 * FileName: P0383.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0383 {
    public class Solution {
        public bool CanConstruct(string ransomNote, string magazine) {
            int[] hash = new int[26];
            foreach (var c in magazine) {
                hash[c - 'a']++;
            }
            foreach (var c in ransomNote) {
                hash[c - 'a']--;
            }
            return hash.All(num => num >= 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanConstruct("aa", "aab");
        Console.WriteLine(ans);
    }
}