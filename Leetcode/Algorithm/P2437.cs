/*
 * Author: Deean
 * Date: 2023-03-18 21:38:51
 * FileName: P2437.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2437 {
    public class Solution {
        public int CountTime(string time) {
            int cnt = 0;
            for (int i = 0; i < 24 * 60; i++) {
                int hh = i / 60, mm = i % 60;
                string cur = string.Format("{0,1:D2}:{1,1:D2}", hh, mm);
                bool flag = true;
                for (int j = 0; j < 5; j++) {
                    if (time[j] != '?' && time[j] != cur[j]) {
                        flag = false;
                        break;
                    }
                }
                if (flag) cnt++;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountTime("0?:0?");
        Console.WriteLine(ans);
    }
}