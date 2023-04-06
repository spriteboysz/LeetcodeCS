/*
 * Author: Deean
 * Date: 2023-04-07 00:00:30
 * FileName: P0242.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0242 {
    public class Solution {
        public bool IsAnagram(string s, string t) {
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