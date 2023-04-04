/*
 * Author: Deean
 * Date: 2023-04-04 10:42:57
 * FileName: P0812.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0812 {
    public class Solution {
        private double Process(int[] point1, int[] point2, int[] point3) {
            return Math.Abs(0.5 * (point1[0] * point2[1] + point2[0] * point3[1] + point3[0] * point1[1] -
                                   point3[0] * point2[1] - point2[0] * point1[1] - point1[0] * point3[1]));
        }

        public double LargestTriangleArea(int[][] points) {
            double maximum = 0.0;
            int n = points.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    for (int k = j + 1; k < n; k++) {
                        maximum = Math.Max(maximum, Process(points[i], points[j], points[k]));
                    }
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestTriangleArea(lib.Arrays.To2DArray("[[0,0],[0,1],[1,0],[0,2],[2,0]]"));
        Console.WriteLine(ans);
    }
}