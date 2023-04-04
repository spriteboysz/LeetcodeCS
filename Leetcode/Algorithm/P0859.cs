/*
 * Author: Deean
 * Date: 2023-04-04 09:00:53
 * FileName: P0859.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0859 {
    public class Solution {
        public bool BuddyStrings(string s, string goal) {
            int n1 = s.Length, n2 = goal.Length;
            if (n1 != n2) return false;
            if (Equals(s, goal)) {
                int[] hash = new int[26];
                foreach (var c in s) {
                    hash[c - 'a']++;
                }
                for (int i = 0; i < 26; i++) {
                    if (hash[i] >= 2) {
                        return true;
                    }
                }
                return false;
            }
            int[] diff = { -1, -1, -1 };
            for (int i = 0, j = 0; i < n1; i++) {
                if (s[i] != goal[i]) {
                    diff[j++] = i;
                }
                if (diff[2] != -1) return false;
            }
            if (diff[0] == -1 || diff[1] == -1) return false;
            return s[diff[0]] == goal[diff[1]] && s[diff[1]] == goal[diff[0]];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BuddyStrings("ab", "ba");
        Console.WriteLine(ans);
    }
}