/*
 * Author: Deean
 * Date: 2023-04-06 22:52:07
 * FileName: P0345.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm; 

public class P0345 {
    public class Solution {
        public string ReverseVowels(string s) {
            string vowels = "aeiouAEIOU";
            StringBuilder target = new StringBuilder();
            foreach (var c in s) {
                if (vowels.Contains(c.ToString())) {
                    target.Append(c);
                }
            }

            StringBuilder ss = new StringBuilder();
            int pos = target.Length - 1;
            foreach (var c in s) {
                ss.Append(vowels.Contains(c.ToString()) ? target[pos--] : c);
            }
            return ss.ToString();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseVowels("leetcode");
        Console.WriteLine(ans);
    }
}