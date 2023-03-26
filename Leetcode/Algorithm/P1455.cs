/*
 * Author: Deean
 * Date: 2023-03-26 23:27:51
 * FileName: P1455.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1455 {
    public class Solution {
        public int IsPrefixOfWord(string sentence, string searchWord) {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                if (words[i].StartsWith(searchWord)) {
                    return i + 1;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPrefixOfWord("this problem is an easy problem", "pro");
        Console.WriteLine(ans);
    }
}