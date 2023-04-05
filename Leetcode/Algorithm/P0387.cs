/*
 * Author: Deean
 * Date: 2023-04-05 22:52:52
 * FileName: P0387.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0387 {
    public class Solution {
        public int FirstUniqChar(string s) {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in s) {
                if (!dict.ContainsKey(c)) {
                    dict.Add(c, 0);
                }
                dict[c]++;
            }
            for (int i = 0, n = s.Length; i < n; i++) {
                if (dict[s[i]] == 1) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FirstUniqChar("leetcode");
        Console.WriteLine(ans);
    }
}