/*
 * Author: Deean
 * Date: 2023-12-12 22:47:53
 * FileName: LCR0173.cs
 * Description: LCR 173. 点名
 */

using System;
using System.Linq;

namespace LCP;

public class LCR0173 {
    public class Solution {
        public int TakeAttendance(int[] records) {
            int n = records.Length;
            return n * (n + 1) / 2 - records.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TakeAttendance(new[] { 0, 1, 2, 3, 5 });
        Console.WriteLine(ans);
    }
}