/*
 * Author: Deean
 * Date: 2023-04-05 16:38:48
 * FileName: P0557.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0557 {
    public class Solution {
        public string ReverseWords(string s) {
            string[] words = s.Split(' ');
            for (int i = 0, n = words.Length; i < n; i++) {
                char[] cs = words[i].ToCharArray();
                Array.Reverse(cs);
                words[i] = new string(cs);
            }
            return string.Join(" ", words);
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseWords("Let's take LeetCode contest");
        Console.WriteLine(ans);
    }
}