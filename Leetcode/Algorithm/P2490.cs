/*
 * Author: Deean
 * Date: 2023-03-18 18:54:50
 * FileName: P2490.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2490 {
    public class Solution {
        public bool IsCircularSentence(string sentence) {
            int n = sentence.Length;
            for (int i = 0; i < n; i++) {
                if (sentence[i] == ' ' && sentence[i - 1] != sentence[i + 1]) {
                    return false;
                }
            }
            return sentence[0] == sentence[n - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsCircularSentence("leetcode exercises sound delightful");
        Console.WriteLine(ans);
        ans = s.IsCircularSentence("Leetcode eisc cool");
        Console.WriteLine(ans);
    }
}