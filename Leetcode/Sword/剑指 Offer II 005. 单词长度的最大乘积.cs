/*
 * Author: Deean
 * Date: 2023-05-21 10:54:34
 * FileName: 剑指 Offer II 005. 单词长度的最大乘积.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_005__单词长度的最大乘积 {
    public class Solution {
        public int MaxProduct(string[] words) {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words) {
                int val = 0;
                foreach (var c in word) {
                    val |= 1 << (c - 'a');
                }
                dict[word] = val;
            }
            int maximum = 0;
            for (int i = 0, n = words.Length; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if ((dict[words[i]] & dict[words[j]]) == 0) {
                        maximum = Math.Max(maximum, words[i].Length * words[j].Length);
                    }
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProduct(new[] { "abcw", "baz", "foo", "bar", "fxyz", "abcdef" });
        Console.WriteLine(ans);
    }
}