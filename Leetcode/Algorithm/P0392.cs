/*
 * Author: Deean
 * Date: 2023-04-05 22:40:36
 * FileName: P0392.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0392 {
    public class Solution {
        public bool IsSubsequence(string s, string t) {
            int n1 = s.Length, n2 = t.Length, pos1 = 0, pos2 = 0;
            while (pos1 < n1 && pos2 < n2) {
                if (s[pos1] == t[pos2]) {
                    pos1++;
                }
                pos2++;
            }
            return pos1 == n1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSubsequence("abc", "ahbgdc");
        Console.WriteLine(ans);
    }
}