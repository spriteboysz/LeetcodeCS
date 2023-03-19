/*
 * Author: Deean
 * Date: 2023-03-19 13:55:03
 * FileName: P2224.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2224 {
    public class Solution {
        private int Process(string t) {
            int hh = (t[0] - '0') * 10 + (t[1] - '0');
            int mm = (t[3] - '0') * 10 + (t[4] - '0');
            return hh * 60 + mm;
        }

        public int ConvertTime(string current, string correct) {
            int diff = Process(correct) - Process(current);
            int cnt = 0;
            foreach (var item in new[] { 60, 15, 5, 1 }) {
                cnt += diff / item;
                diff %= item;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertTime("02:30", "04:35");
        Console.WriteLine(ans);
    }
}