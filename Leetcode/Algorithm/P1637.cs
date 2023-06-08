/*
 * Author: Deean
 * Date: 2023-06-07 22:50:49
 * FileName: P1637.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1637 {
    public class Solution {
        public int MaxWidthOfVerticalArea(int[][] points) {
            Array.Sort(points, (a, b) => a[0] - b[0]);
            int maximum = 0;
            for (int i = 1; i < points.Length; i++) {
                maximum = Math.Max(maximum, points[i][0] - points[i - 1][0]);
            }
            return maximum;
        }
    }

    public static void Test() {
        var points = Arrays.To2DArray("[[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]");
        var s = new Solution();
        var ans = s.MaxWidthOfVerticalArea(points);
        Console.WriteLine(ans);
    }
}