/*
 * Author: Deean
 * Date: 2023-03-26 22:15:36
 * FileName: P1736.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1736 {
    public class Solution {
        public string MaximumTime(string time) {
            for (int i = 24 * 60 - 1; i >= 0; i--) {
                int hh = i / 60, mm = i % 60;
                string cur = $"{hh:D2}:{mm:D2}";
                bool flag = true;
                for (int j = 0; j < 5; j++) {
                    if (time[j] != '?' && time[j] != cur[j]) {
                        flag = false;
                        break;
                    }
                }
                if (flag) return cur;
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumTime("2?:?0");
        Console.WriteLine(ans);
    }
}