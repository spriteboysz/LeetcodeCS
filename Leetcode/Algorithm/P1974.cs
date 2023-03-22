/*
 * Author: Deean
 * Date: 2023-03-22 23:18:01
 * FileName: P1974.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1974 {
    public class Solution {
        public int MinTimeToType(string word) {
            int cnt = 0;
            char pos = 'a';
            foreach (var c in word) {
                int cur = Math.Min(Math.Abs(c - pos), 26 - Math.Abs(c - pos));
                cnt += cur + 1;
                pos = c;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinTimeToType("bza");
        Console.WriteLine(ans);
    }
}