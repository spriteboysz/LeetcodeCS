/*
 * Author: Deean
 * Date: 2023-11-09 22:45:10
 * FileName: LCR0098.cs
 * Description: LCR 098. 不同路径
 */

using System;
using System.Linq;

namespace LCP;

public class LCR0098 {
    public class Solution {
        public int UniquePaths(int m, int n) {
            int[][] grid = new int[m][];
            for (int i = 0; i < m; i++) {
                grid[i] = new int[n];
            }
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == 0 || j == 0) {
                        grid[i][j] = 1;
                    } else {
                        grid[i][j] = grid[i - 1][j] + grid[i][j - 1];
                    }
                }
            }
            return grid.Last().Last();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.UniquePaths(3, 7);
        Console.WriteLine(ans);
    }
}