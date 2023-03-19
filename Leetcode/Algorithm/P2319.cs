/*
 * Author: Deean
 * Date: 2023-03-19 10:12:58
 * FileName: P2319.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2319 {
    public class Solution {
        public bool CheckXMatrix(int[][] grid) {
            int n = grid.Length;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j || i + j == n - 1) {
                        if (grid[i][j] == 0) return false;
                    } else {
                        if (grid[i][j] != 0) return false;
                    }
                }
            }
            return true;
        }
    }

    public static void Test() {
        int[][] grid = new int[3][];
        grid[0] = new[] { 5, 7, 0 };
        grid[1] = new[] { 0, 3, 1 };
        grid[2] = new[] { 0, 5, 0 };
        var s = new Solution();
        var ans = s.CheckXMatrix(grid);
        Console.WriteLine(ans);
    }
}