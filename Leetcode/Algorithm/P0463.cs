/*
 * Author: Deean
 * Date: 2023-04-04 20:00:01
 * FileName: P0463.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0463 {
    public class Solution {
        public int IslandPerimeter(int[][] grid) {
            int perimeter = 0, n = grid.Length, m = grid[0].Length;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (grid[i][j] == 0) continue;
                    if (i == 0 || grid[i - 1][j] == 0) {
                        perimeter++;
                    }
                    if (i == n - 1 || grid[i + 1][j] == 0) {
                        perimeter++;
                    }
                    if (j == 0 || grid[i][j - 1] == 0) {
                        perimeter++;
                    }
                    if (j == m - 1 || grid[i][j + 1] == 0) {
                        perimeter++;
                    }
                }
            }
            return perimeter;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IslandPerimeter(lib.Arrays.To2DArray("[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]"));
        Console.WriteLine(ans);
    }
}