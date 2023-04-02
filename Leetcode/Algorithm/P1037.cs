/*
 * Author: Deean
 * Date: 2023-04-01 23:18:31
 * FileName: P1037.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1037 {
    public class Solution {
        public bool IsBoomerang(int[][] points) {
            int dx = points[1][0] - points[0][0], dy = points[1][1] - points[0][1];
            int cx = points[2][0] - points[0][0], cy = points[2][1] - points[0][1];
            return dx * cy != dy * cx;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsBoomerang(lib.Arrays.To2DArray("[[1,1],[2,3],[3,2]]"));
        Console.WriteLine(ans);
    }
}