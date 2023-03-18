/*
 * Author: Deean
 * Date: 2023-03-18 21:25:48
 * FileName: P02446.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P02446 {
    public class Solution {
        int Process(string t) {
            int hh = (t[0] - '0') * 10 + (t[1] - '0');
            int mm = (t[3] - '0') * 10 + (t[4] - '0');
            return hh * 60 + mm;
        }

        public bool HaveConflict(string[] event1, string[] event2) {
            return Process(event1[0]) <= Process(event2[1]) &&
                   Process(event1[1]) >= Process(event2[0]);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HaveConflict(new[] { "01:15", "02:00" }, new[] { "02:00", "03:00" });
        Console.WriteLine(ans);
    }
}