/*
 * Author: Deean
 * Date: 2023-03-19 20:17:06
 * FileName: P2053.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2053 {
    public class Solution {
        public string KthDistinct(string[] arr, int k) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in arr) {
                if (dict.ContainsKey(word)) {
                    dict[word] += 1;
                } else {
                    dict.Add(word, 1);
                }
            }
            foreach (var word in arr) {
                if (dict[word] == 1) {
                    k--;
                }
                if (k == 0) return word;
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KthDistinct(new[] { "d", "b", "c", "b", "c", "a" }, 2);
        Console.WriteLine(ans);
    }
}