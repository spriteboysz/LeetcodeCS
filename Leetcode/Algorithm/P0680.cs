/*
 * Author: Deean
 * Date: 2023-04-04 19:38:52
 * FileName: P0680.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0680 {
    public class Solution {
        private bool Check(string s, int left, int right) {
            while (left < right) {
                if (s[left++] != s[right--]) {
                    return false;
                }
            }
            return true;
        }

        public bool ValidPalindrome(string s) {
            if (s.Length <= 2) return true;
            int left = 0, right = s.Length - 1;
            while (left < right) {
                if (s[left] == s[right]) {
                    left++;
                    right--;
                } else {
                    return Check(s, left + 1, right) || Check(s, left, right - 1);
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ValidPalindrome("abca");
        Console.WriteLine(ans);
    }
}