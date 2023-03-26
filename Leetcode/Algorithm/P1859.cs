/*
 * Author: Deean
 * Date: 2023-03-25 21:54:31
 * FileName: P1859.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm; 

public class P1859 {
    public class Solution {
        public string SortSentence(string s) {
            string[] words = s.Split(' ');
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (var word in words) {
                int n = word.Length;
                int key = word[n - 1] - '0';
                string value = word.Substring(0, n - 1);
                dict.Add(key, value);
            }
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < words.Length; i++) {
                ss.Append(dict[i + 1]);
                ss.Append(' ');
            }
            return ss.ToString().Trim();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortSentence("is2 sentence4 This1 a3");
        Console.WriteLine(ans);
    }
}