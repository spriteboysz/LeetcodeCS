/*
 * Author: Deean
 * Date: 2023-11-10 21:48:40
 * FileName: LCR0099.cs
 * Description: LCR 099. 最小路径和
 */

using System;
using System.Linq;
using lib;

namespace LCP;

public class LCR0099 {
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
        var s = new Solution();
        var ans = s.MinPathSum(Arrays.To2DArray("[[1,3,1],[1,5,1],[4,2,1]]"));
        Console.WriteLine(ans);
    }
}