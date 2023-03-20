/*
 * Author: Deean
 * Date: 2023-03-20 23:28:59
 * FileName: P2129.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2129 {
    public class Solution {
        public string CapitalizeTitle(string title) {
            string[] words = title.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                words[i] = words[i].ToLower();
                if (words[i].Length > 2) {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CapitalizeTitle("First leTTeR of EACH Word");
        Console.WriteLine(ans);
    }
}