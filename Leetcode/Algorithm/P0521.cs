/*
 * Author: Deean
 * Date: 2023-04-05 16:12:02
 * FileName: P0521.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0521 {
    public class Solution {
        public int FindLUSlength(string a, string b) {
            return a.Equals(b) ? -1 : Math.Max(a.Length, b.Length);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindLUSlength("abc", "abc");
        Console.WriteLine(ans);
    }
}