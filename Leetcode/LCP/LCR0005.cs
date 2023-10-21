/*
 * Author: Deean
 * Date: 2023-10-20 22:50:56
 * FileName: LCR0005.cs
 * Description: LCR 005. 最大单词长度乘积
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0005 {
    public class Solution {
        public int MaxProduct(string[] words) {
            IDictionary<string, int> hash = new Dictionary<string, int>();
            foreach (var word in words) {
                int val = 0;
                foreach (var c in word) {
                    val |= 1 << (c - 'a');
                }
                hash[word] = val;
            }
            int maximum = 0;
            for (int i = 0, n = words.Length; i < n; i++) {
                for (int j = 0; j < i; j++) {
                    if ((hash[words[i]] & hash[words[j]]) == 0) {
                        maximum = Math.Max(maximum, words[i].Length * words[j].Length);
                    }
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProduct(new[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" });
        Console.WriteLine(ans);
    }
}