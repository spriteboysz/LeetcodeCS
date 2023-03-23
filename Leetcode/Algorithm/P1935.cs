/*
 * Author: Deean
 * Date: 2023-03-23 23:15:49
 * FileName: P1935.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1935 {
    public class Solution {
        public int CanBeTypedWords(string text, string brokenLetters) {
            string[] words = text.Split(' ');
            return words.Count(word => brokenLetters.All(c => !word.Contains(c.ToString())));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanBeTypedWords("hello world", "ad");
        Console.WriteLine(ans);
    }
}