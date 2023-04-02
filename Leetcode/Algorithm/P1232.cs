/*
 * Author: Deean
 * Date: 2023-04-01 22:47:30
 * FileName: P1232.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1232 {
    public class Solution {
        public bool CheckStraightLine(int[][] coordinates) {
            int n = coordinates.Length;
            if (n == 2) return true;
            int dx = coordinates[1][0] - coordinates[0][0];
            int dy = coordinates[1][1] - coordinates[0][1];
            for (int i = 2; i < n; i++) {
                int cx = coordinates[i][0] - coordinates[0][0];
                int cy = coordinates[i][1] - coordinates[0][1];
                if (dx * cy != dy * cx) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckStraightLine(lib.Arrays.To2DArray("[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]"));
        Console.WriteLine(ans);
    }
}