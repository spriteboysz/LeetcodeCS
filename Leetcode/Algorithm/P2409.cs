/*
 * Author: Deean
 * Date: 2023-03-18 23:07:19
 * FileName: P2409.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2409 {
    public class Solution {
        public int Process(string date) {
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mm = (date[0] - '0') * 10 + date[1] - '0', dd = (date[3] - '0') * 10 + date[4] - '0';
            for (int i = 0; i < mm - 1; i++) {
                dd += months[i];
            }
            return dd;
        }

        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob) {
            return Math.Max(
                Math.Min(Process(leaveAlice), Process(leaveBob)) - Math.Max(Process(arriveAlice), Process(arriveBob)) +
                1, 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountDaysTogether("08-15", "08-18", "08-16", "08-19");
        Console.WriteLine(ans);
    }
}