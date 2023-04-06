/*
 * Author: Deean
 * Date: 2023-04-05 20:12:45
 * FileName: P0409.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0409 {
    public class Solution {
        public int LongestPalindrome(string s) {
            int[] hash = new int[52];
            foreach (var c in s) {
                if (char.IsLower(c)) {
                    hash[c - 'a']++;
                } else {
                    hash[26 + c - 'A']++;
                }
            }
            int cnt = 0, odd = 0;
            foreach (var num in hash) {
                if (num % 2 == 1) odd = 1;
                cnt += (num >> 1) << 1;
            }
            return cnt + odd;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LongestPalindrome("abccccdd");
        Console.WriteLine(ans);
    }
}