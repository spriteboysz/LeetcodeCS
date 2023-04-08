/*
 * Author: Deean
 * Date: 2023-04-08 17:48:44
 * FileName: 剑指 Offer II 032. 有效的变位词.cs
 * Description:
*/

using System;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_032__有效的变位词 {
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