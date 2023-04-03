/*
 * Author: Deean
 * Date: 2023-04-02 22:03:44
 * FileName: P0883.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0883 {
    public class Solution {
        public int ProjectionArea(int[][] grid) {
            int area = 0;
            int n = grid.Length, m = grid[0].Length;
            int[] rows = new int[n], cols = new int[m];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    rows[i] = Math.Max(rows[i], grid[i][j]);
                    cols[j] = Math.Max(cols[j], grid[i][j]);
                    if (grid[i][j] > 0) area++;
                }
            }
            return area + rows.Sum() + cols.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ProjectionArea(lib.Arrays.To2DArray("[[1,2],[3,4]]"));
        Console.WriteLine(ans);
    }
}