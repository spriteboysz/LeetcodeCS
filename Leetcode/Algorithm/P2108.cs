/*
 * Author: Deean
 * Date: 2023-03-20 23:10:00
 * FileName: P2108.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2108 {
    public class Solution {
        public string FirstPalindrome(string[] words) {
            foreach (var word in words) {
                int n = word.Length;
                bool flag = true;
                for (int i = 0; i < n / 2; i++) {
                    if (word[i] != word[n - 1 - i]) {
                        flag = false;
                        break;
                    }
                }
                if (flag) return word;
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FirstPalindrome(new[] { "abc", "car", "ada", "racecar", "cool" });
        Console.WriteLine(ans);
    }
}