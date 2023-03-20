/*
 * Author: Deean
 * Date: 2023-03-19 20:10:36
 * FileName: P2047.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2047 {
    public class Solution {
        public int CountValidWords(string sentence) {
            string[] words = System.Text.RegularExpressions.Regex.Split(sentence.Trim(), @"\s+");
            int cnt = 0;

            foreach (var word in words) {
                bool hasDash = false, hasSymbol = false, legal = true;
                for (int i = 0; i < word.Length; i++) {
                    if (char.IsDigit(word[i])) {
                        legal = false;
                        break;
                    }
                    if (word[i] == '-') {
                        if (i == 0 || i == word.Length - 1 || hasDash || !char.IsLower(word[i - 1]) ||
                            !char.IsLower(word[i + 1])) {
                            legal = false;
                            break;
                        }
                        hasDash = true;
                    }
                    if (word[i] == '!' || word[i] == ',' || word[i] == '.') {
                        if (hasSymbol || i != word.Length - 1) {
                            legal = false;
                            break;
                        }
                        hasSymbol = true;
                    }
                }
                if (legal) cnt++;
            }

            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountValidWords("cat and  dog");
        Console.WriteLine(ans);
    }
}