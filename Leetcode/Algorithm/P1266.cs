/*
 * Author: Deean
 * Date: 2023-03-31 22:55:30
 * FileName: P1266.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1266 {
    public class Solution {
        public int MinTimeToVisitAllPoints(int[][] points) {
            int cnt = 0;
            for (int i = 1; i < points.Length; i++) {
                int[] prev = points[i - 1];
                int[] curr = points[i];
                cnt += Math.Max(Math.Abs(curr[0] - prev[0]), Math.Abs(curr[1] - prev[1]));
            }
            return cnt;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinTimeToVisitAllPoints(lib.Arrays.To2DArray("[[1,1],[3,4],[-1,0]]"));
        Console.WriteLine(ans);
    }
}