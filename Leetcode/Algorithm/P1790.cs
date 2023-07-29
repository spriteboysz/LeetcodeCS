/*
 * Author: Deean
 * Date: 2023-03-25 22:33:10
 * FileName: P1970.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1790 {
    public class Solution {
        public bool AreAlmostEqual(string s1, string s2) {
            int n = s1.Length;
            List<int> diff = new List<int>();
            for (int i = 0; i < n; i++) {
                if (s1[i] != s2[i]) {
                    if (diff.Count >= 2) return false;
                    diff.Add(i);
                }
            }
            if (diff.Count == 0) return true;
            if (diff.Count == 1) return false;
            return s1[diff[0]] == s2[diff[1]] && s1[diff[1]] == s2[diff[0]];
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AreAlmostEqual("bank", "kanb");
        Console.WriteLine(ans);
    }
}