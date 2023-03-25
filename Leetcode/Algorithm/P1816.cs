/*
 * Author: Deean
 * Date: 2023-03-24 23:25:12
 * FileName: P1816.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1816 {
    public class Solution {
        public string TruncateSentence(string s, int k) {
            int n = s.Length;
            for (int i = 1; i <= n; i++) {
                if (i == n || s[i] == ' ') {
                    k--;
                    if (k == 0) {
                        return s.Substring(0, i);
                    }
                }
            }
            return s;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TruncateSentence("Hello how are you Contestant", 4);
        Console.WriteLine(ans);
    }
}