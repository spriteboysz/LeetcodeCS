/*
 * Author: Deean
 * Date: 2023-04-04 09:58:44
 * FileName: P0824.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0824 {
    public class Solution {
        public string ToGoatLatin(string sentence) {
            string vowels = "aeiouAEIOU";
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                string word = words[i];
                if (vowels.Contains(word[0])) {
                    word = word + "ma";
                } else {
                    word = word.Substring(1) + word[0] + "ma";
                }
                for (int j = 0; j <= i; j++) {
                    word += "a";
                }
                words[i] = word;
            }
            return String.Join(" ", words);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ToGoatLatin("I speak Goat Latin");
        Console.WriteLine(ans);
    }
}