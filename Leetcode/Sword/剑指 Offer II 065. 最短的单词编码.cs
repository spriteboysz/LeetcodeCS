/*
 * Author: Deean
 * Date: 2023-05-27 22:34:37
 * FileName: 剑指 Offer II 065. 最短的单词编码.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_065__最短的单词编码 {
    public class Solution {
        public int MinimumLengthEncoding(string[] words) {
            Array.Sort(words, (s1, s2) => s1.Length - s2.Length);
            int len = 0;
            for (int i = 0, n = words.Length; i < n; i++) {
                bool flag = true;
                for (int j = i + 1; j < n; j++) {
                    if (words[j].EndsWith(words[i])) {
                        flag = false;
                        break;
                    }
                }
                if (flag) len += words[i].Length + 1;
            }
            return len;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumLengthEncoding(new[] { "time", "me", "bell" });
        Console.WriteLine(ans);
    }
}