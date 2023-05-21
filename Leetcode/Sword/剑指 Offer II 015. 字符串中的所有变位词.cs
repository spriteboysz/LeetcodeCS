/*
 * Author: Deean
 * Date: 2023-05-21 15:15:49
 * FileName: 剑指 Offer II 015. 字符串中的所有变位词.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_015__字符串中的所有变位词 {
    public class Solution {
        private bool Check(int[] nums1, int[] nums2) {
            for (int i = 0; i < nums1.Length; i++) {
                if (nums1[i] != nums2[i]) {
                    return false;
                }
            }
            return true;
        }

        public IList<int> FindAnagrams(string s, string p) {
            IList<int> index = new List<int>();
            int n = s.Length, m = p.Length;
            if (n < m) return index;
            int[] hash = new int[26];
            foreach (var c in p) {
                hash[c - 'a']++;
            }
            int[] hash1 = new int[26];
            for (int i = 0; i < m; i++) {
                hash1[s[i] - 'a']++;
            }
            if (Check(hash, hash1)) index.Add(0);
            for (int i = m; i < n; i++) {
                hash1[s[i - m] - 'a']--;
                hash1[s[i] - 'a']++;
                if (Check(hash1, hash)) index.Add(i - m + 1);
            }
            return index;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindAnagrams("abab", "ab");
        Console.WriteLine(Arrays.ToString(ans));
    }
}