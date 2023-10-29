/*
 * Author: Deean
 * Date: 2023-10-23 23:07:28
 * FileName: LCR0065.cs
 * Description: LCR 065. 单词的压缩编码
 */

using System;

namespace LCP;

public class LCR0065 {
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