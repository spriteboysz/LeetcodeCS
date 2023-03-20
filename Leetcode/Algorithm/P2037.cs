/*
 * Author: Deean
 * Date: 2023-03-19 20:01:28
 * FileName: P2037.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2037 {
    public class Solution {
        public int MinMovesToSeat(int[] seats, int[] students) {
            Array.Sort(seats);
            Array.Sort(students);
            int cnt = 0;
            for (int i = 0; i < seats.Length; i++) {
                cnt += Math.Abs(seats[i] - students[i]);
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinMovesToSeat(new[] { 4, 1, 5, 9 }, new[] { 1, 3, 2, 6 });
        Console.WriteLine(ans);
    }
}