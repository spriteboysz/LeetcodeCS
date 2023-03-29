/*
 * Author: Deean
 * Date: 2023-03-28 23:52:04
 * FileName: P1598.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1598 {
    public class Solution {
        public int MinOperations(string[] logs) {
            int depth = 0;
            foreach (var log in logs) {
                if ("./".Equals(log)) continue;
                if ("../".Equals(log)) {
                    if (depth > 0) {
                        depth--;
                    }
                } else {
                    depth++;
                }
            }
            return depth;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinOperations(new[] { "d1/", "d2/", "../", "d21/", "./" });
        Console.WriteLine(ans);
    }
}