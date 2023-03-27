/*
 * Author: Deean
 * Date: 2023-03-27 23:05:19
 * FileName: P1507.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1507 {
    public class Solution {
        public string ReformatDate(string date) {
            string[] dates = date.Split(' ');
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int mm = Array.IndexOf(months, dates[1]) + 1;
            int dd = 0;
            for (int i = 0; i < dates[0].Length - 2; i++) {
                dd = 10 * dd + dates[0][i] - '0';
            }
            return $"{dates[2]}-{mm:D2}-{dd:D2}";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReformatDate("20th Oct 2052");
        Console.WriteLine(ans);
    }
}