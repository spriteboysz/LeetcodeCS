/*
 * Author: Deean
 * Date: 2023-05-31 22:29:35
 * FileName: P0064.cs
 * Description:
*/

using System;
using System.Linq;
using lib;

namespace Algorithm;

public class P0064 {
    public class Solution {
        public int MinPathSum(int[][] grid) {
            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[0].Length; j++) {
                    if (i == 0 && j == 0) continue;
                    if (i == 0) {
                        grid[i][j] += grid[i][j - 1];
                    } else if (j == 0) {
                        grid[i][j] += grid[i - 1][j];
                    } else {
                        grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                    }
                }
            }
            return grid.Last().Last();
        }
    }

    public static void Test() {
        var grid = Arrays.To2DArray("[[1,3,1],[1,5,1],[4,2,1]]");
        var s = new Solution();
        var ans = s.MinPathSum(grid);
        Console.WriteLine(ans);
    }
}