/*
 * Author: Deean
 * Date: 2023-04-07 23:03:25
 * FileName: P0205.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0205 {
    public class Solution {
        public bool IsIsomorphic(string s, string t) {
            Dictionary<char, char> dict1 = new Dictionary<char, char>();
            Dictionary<char, char> dict2 = new Dictionary<char, char>();
            if (s.Length != t.Length) return false;
            for (int i = 0, n = s.Length; i < n; i++) {
                if (!dict1.ContainsKey(s[i])) {
                    dict1.Add(s[i], t[i]);
                } else if (dict1[s[i]] != t[i]) {
                    return false;
                }
                if (!dict2.ContainsKey(t[i])) {
                    dict2.Add(t[i], s[i]);
                } else if (dict2[t[i]] != s[i]) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsIsomorphic("egg", "add");
        Console.WriteLine(ans);
    }
}