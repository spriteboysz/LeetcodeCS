/*
 * Author: Deean
 * Date: 2023-06-06 23:33:08
 * FileName: P1689.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1689 {
    public class Solution {
        public int MinPartitions(string n) {
            for (int i = 10 - 1; i >= 0; i--) {
                if (n.Contains(i.ToString())) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinPartitions("27346209830709182346");
        Console.WriteLine(ans);
    }
}