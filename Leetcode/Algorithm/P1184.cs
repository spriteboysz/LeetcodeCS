/*
 * Author: Deean
 * Date: 2023-04-01 22:10:37
 * FileName: P1184.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1184 {
    public class Solution {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
            int sum = distance.Sum();
            int dis = 0;
            for (int i = Math.Min(start, destination); i < Math.Max(start, destination); i++) {
                dis += distance[i];
            }
            return Math.Min(dis, sum - dis);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistanceBetweenBusStops(new[] { 1, 2, 3, 4 }, 0, 1);
        Console.WriteLine(ans);
    }
}