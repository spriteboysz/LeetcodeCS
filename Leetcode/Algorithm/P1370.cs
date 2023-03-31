/*
 * Author: Deean
 * Date: 2023-03-30 22:53:13
 * FileName: P1370.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1370 {
    public class Solution {
        public string SortString(string s) {
            int[] hash = new int[26];
            foreach (var c in s) {
                hash[c - 'a'] += 1;
            }
            int n = s.Length;
            StringBuilder ss = new StringBuilder();
            while (n > 0) {
                for (int i = 0; i < 26; i++) {
                    if (hash[i] > 0) {
                        ss.Append((char)('a' + i));
                        hash[i]--;
                        n--;
                    }
                }
                for (int i = 26 - 1; i >= 0; i--) {
                    if (hash[i] > 0) {
                        ss.Append((char)('a' + i));
                        hash[i]--;
                        n--;
                    }
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortString("aaaabbbbcccc");
        Console.WriteLine(ans);
    }
}