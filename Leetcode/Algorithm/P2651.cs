/*
 * Author: Deean
 * Date: 2023-05-20 15:05:40
 * FileName: P2651.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2651 {
    public class Solution {
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
            return (arrivalTime + delayedTime) % 24;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindDelayedArrivalTime(13, 11);
        Console.WriteLine(ans);
    }
}