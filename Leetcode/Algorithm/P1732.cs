/*
 * Author: Deean
 * Date: 2023-03-26 22:11:38
 * FileName: P1732.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1732 {
    public class Solution {
        public int LargestAltitude(int[] gain) {
            int altitude = 0, cur = 0;
            foreach (var num in gain) {
                cur += num;
                altitude = Math.Max(altitude, cur);
            }
            return altitude;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestAltitude(new[] { -5, 1, 5, 0, -7 });
        Console.WriteLine(ans);
    }
}