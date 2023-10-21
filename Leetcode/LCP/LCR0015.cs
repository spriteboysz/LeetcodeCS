/*
 * Author: Deean
 * Date: 2023-10-20 23:12:41
 * FileName: LCR0015.cs
 * Description: LCR 015. 找到字符串中所有字母异位词
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP; 

public class LCR0015 {
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
        var ans = s.FindAnagrams("cbaebabacd", "abc");
        Console.WriteLine(Arrays.ToString(ans));
    }
}