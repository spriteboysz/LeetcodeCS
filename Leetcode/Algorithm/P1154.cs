/*
 * Author: Deean
 * Date: 2023-04-01 21:28:58
 * FileName: P1154.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1154 {
    public class Solution {
        private int isLeap(int year) {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? 1 : 0;
        }

        public int DayOfYear(string date) {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int yy = Int32.Parse(date.Substring(0, 4));
            int mm = Int32.Parse(date.Substring(5, 2));
            int days = Int32.Parse(date.Substring(8));
            months[2] += isLeap(yy);
            for (int i = 0; i < mm; i++) {
                days += months[i];
            }
            return days;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DayOfYear("2019-01-09");
        Console.WriteLine(ans);
    }
}