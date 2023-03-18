/*
 * Author: Deean
 * Date: 2023-03-18 18:33:15
 * FileName: P2500.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2500 {
    public class Solution {
        public int DeleteGreatestValue(int[][] grid) {
            int m = grid.Length, n = grid[0].Length;
            for (int i = 0; i < m; i++) {
                Array.Sort(grid[i]);
            }
            int value = 0;
            for (int j = 0; j < n; j++) {
                int v = 0;
                for (int i = 0; i < m; i++) {
                    v = Math.Max(v, grid[i][j]);
                }
                value += v;
            }
            return value;
        }
    }

    public static void Test() {
        int[][] grid = new int [2][];
        grid[0] = new[] { 1, 2, 4 };
        grid[1] = new[] { 3, 3, 1 };
        var s = new Solution();
        var ans = s.DeleteGreatestValue(grid);
        Console.WriteLine(ans);
    }
}