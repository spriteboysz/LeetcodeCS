/*
 * Author: Deean
 * Date: 2023-04-04 10:59:16
 * FileName: P0796.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0796 {
    public class Solution {
        public bool RotateString(string s, string goal) {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RotateString("abcde", "cdeab");
        Console.WriteLine(ans);
    }
}