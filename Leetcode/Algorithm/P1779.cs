/*
 * Author: Deean
 * Date: 2023-03-25 22:44:29
 * FileName: P1779.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1779 {
    public class Solution {
        public int NearestValidPoint(int x, int y, int[][] points) {
            int minimum = int.MaxValue;
            foreach (var point in points) {
                int a = point[0], b = point[1];
                if (a == x || b == y) {
                    minimum = Math.Min(minimum, Math.Abs(x - a) + Math.Abs(y - b));
                }
            }
            for (int i = 0; i < points.Length; i++) {
                int a = points[i][0], b = points[i][1];
                if ((a == x || b == y) && Math.Abs(x - a) + Math.Abs(y - b) == minimum) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NearestValidPoint(3, 4, lib.Arrays.To2DArray("[[1,2],[3,1],[2,4],[2,3],[4,4]]"));
        Console.WriteLine(ans);
    }
}