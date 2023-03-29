/*
 * Author: Deean
 * Date: 2023-03-28 23:35:52
 * FileName: P1614.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1614 {
    public class Solution {
        public int MaxDepth(string s) {
            int maximum = 0, depth = 0;
            foreach (var c in s) {
                if (c == '(') depth++;
                maximum = Math.Max(maximum, depth);
                if (c == ')') depth--;
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDepth("(1+(2*3)+((8)/4))+1");
        Console.WriteLine(ans);
    }
}