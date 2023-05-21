/*
 * Author: Deean
 * Date: 2023-05-21 15:30:23
 * FileName: P0567.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0567 {
    public class Solution {
        private bool Check(int[] nums1, int[] nums2) {
            for (int i = 0; i < nums1.Length; i++) {
                if (nums1[i] != nums2[i]) {
                    return false;
                }
            }
            return true;
        }

        public bool CheckInclusion(string s1, string s2) {
            int[] hash = new int[26], hash1 = new int[26];
            int m = s1.Length, n = s2.Length;
            if (m > n) return false;
            foreach (var c in s1) {
                hash[c - 'a']++;
            }
            for (int i = 0; i < m; i++) {
                hash1[s2[i] - 'a']++;
            }
            if (Check(hash, hash1)) return true;
            for (int i = m; i < n; i++) {
                hash1[s2[i - m] - 'a']--;
                hash1[s2[i] - 'a']++;
                if (Check(hash, hash1)) return true;
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckInclusion("ab", "eidbaooo");
        Console.WriteLine(ans);
    }
}