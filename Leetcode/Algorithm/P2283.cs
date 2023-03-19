/*
 * Author: Deean
 * Date: 2023-03-19 11:24:52
 * FileName: P2283.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2283 {
    public class Solution {
        public bool DigitCount(string num) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var c in num) {
                int key = c - '0';
                if (dict.ContainsKey(key)) {
                    dict[key] += 1;
                } else {
                    dict.Add(key, 1);
                }
            }
            for (int i = 0; i < num.Length; i++) {
                if (!dict.ContainsKey(i)) {
                    dict.Add(i, 0);
                }
                if (dict[i] != num[i] - '0') {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DigitCount("1210");
        Console.WriteLine(ans);
    }
}