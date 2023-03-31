/*
 * Author: Deean
 * Date: 2023-03-30 23:08:26
 * FileName: P1360.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1360 {
    public class Solution {
        private int isLeap(int year) {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? 1 : 0;
        }

        private int Process(string date) {
            int yy = 0, mm = 0, dd = 0;
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            foreach (var c in date.Substring(0, 4)) {
                yy = yy * 10 + c - '0';
            }
            foreach (var c in date.Substring(5, 2)) {
                mm = mm * 10 + c - '0';
            }
            foreach (var c in date.Substring(8, 2)) {
                dd = dd * 10 + c - '0';
            }

            for (int i = 1970; i < yy; i++) {
                dd += isLeap(i) + 365;
            }
            if (isLeap(yy) == 1) months[1] = 29;
            for (int i = 0; i < mm; i++) {
                dd += months[i];
            }
            return dd;
        }

        public int DaysBetweenDates(string date1, string date2) {
            return Math.Abs(Process(date1) - Process(date2));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DaysBetweenDates("2019-06-29", "2019-06-30");
        Console.WriteLine(ans);
    }
}