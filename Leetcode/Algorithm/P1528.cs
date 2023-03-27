/*
 * Author: Deean
 * Date: 2023-03-27 23:34:07
 * FileName: P1528.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1528 {
    public class Solution {
        public string RestoreString(string s, int[] indices) {
            int n = s.Length;
            char[] ss = new char[n];
            for (int i = 0; i < n; i++) {
                ss[indices[i]] = s[i];
            }
            return new string(ss);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RestoreString("codeleet", new[] { 4, 5, 6, 7, 0, 2, 1, 3 });
        Console.WriteLine(ans);
    }
}