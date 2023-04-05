/*
 * Author: Deean
 * Date: 2023-04-04 22:02:39
 * FileName: P0495.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0495 {
    public class Solution {
        public int FindPoisonedDuration(int[] timeSeries, int duration) {
            int cnt = 0, expired = 0;
            foreach (var t in timeSeries) {
                if (t >= expired) {
                    cnt += duration;
                } else {
                    cnt += t + duration - expired;
                }
                expired = t + duration;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindPoisonedDuration(new[] { 1, 4 }, 2);
        Console.WriteLine(ans);
    }
}