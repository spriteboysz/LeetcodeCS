/*
 * Author: Deean
 * Date: 2023-04-01 22:14:14
 * FileName: P1185.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1185 {
    public class Solution {
        private int IsLeap(int year) {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? 1 : 0;
        }

        public string DayOfTheWeek(int day, int month, int year) {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] weekday = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int days = day;
            for (int i = 1970; i < year; i++) {
                days += 365 + IsLeap(i);
            }
            if (IsLeap(year) == 1) months[2] = 29;
            for (int i = 0; i < month; i++) {
                days += months[i];
            }
            return weekday[(days + 3) % 7];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DayOfTheWeek(31, 8, 2019);
        Console.WriteLine(ans);
    }
}