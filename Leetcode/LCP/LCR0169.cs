/*
 * Author: Deean
 * Date: 2023-12-09 16:15:58
 * FileName: LCR0169.cs
 * Description: LCR 169. 招式拆解 II
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0169 {
    public class Solution {
        public char DismantlingAction(string s) {
            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in s) {
                if (!dict.ContainsKey(c)) {
                    dict.Add(c, 0);
                }
                dict[c]++;
            }
            foreach (var c in s) {
                if (dict[c] == 1) {
                    return c;
                }
            }
            return ' ';
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DismantlingAction("abbccdeff");
        Console.WriteLine(ans);
    }
}