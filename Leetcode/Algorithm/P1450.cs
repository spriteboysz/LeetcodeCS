/*
 * Author: Deean
 * Date: 2023-03-26 23:24:30
 * FileName: P1450.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1450 {
    public class Solution {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
            int cnt = 0;
            for (int i = 0; i < startTime.Length; i++) {
                if (queryTime >= startTime[i] && queryTime <= endTime[i]) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BusyStudent(new[] { 1, 2, 3 }, new[] { 3, 2, 7 }, 4);
        Console.WriteLine(ans);
    }
}