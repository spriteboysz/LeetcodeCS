/*
 * Author: Deean
 * Date: 2023-10-21 14:46:14
 * FileName: LCR0032.cs
 * Description: LCR 032. 有效的字母异位词
 */

using System;
using System.Linq;

namespace LCP; 

public class LCR0032 {
    public class Solution {
        public bool IsAnagram(string s, string t) {
            if (Equals(s, t)) return false;
            int[] hash = new int[26];
            foreach (var c in s) {
                hash[c - 'a']++;
            }
            foreach (var c in t) {
                hash[c - 'a']--;
            }
            return hash.All(num => num == 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsAnagram("anagram", "nagaram");
        Console.WriteLine(ans);
    }
}