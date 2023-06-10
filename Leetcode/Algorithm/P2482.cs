/*
 * Author: Deean
 * Date: 2023-06-09 23:24:33
 * FileName: P2482.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2482 {
    public class Solution {
        public int[][] OnesMinusZeros(int[][] grid) {
            int m = grid.Length, n = grid[0].Length;
            int[] rows = new int[m], cols = new int[n];
            for (var i = 0; i < m; i++) {
                for (var j = 0; j < n; j++) {
                    if (grid[i][j] == 1) {
                        rows[i] += 1;
                        cols[j] += 1;
                    }
                }
            }
            var res = new int[m][];
            for (var i = 0; i < m; i++) res[i] = new int[n];
            for (var i = 0; i < m; i++) {
                for (var j = 0; j < n; j++) {
                    res[i][j] = 2 * rows[i] + 2 * cols[j] - m - n;
                }
            }
            return res;
        }
    }

    public static void Test() {
        var grid = Arrays.To2DArray("[[0,1,1],[1,0,1],[0,0,1]]");
        var s = new Solution();
        var ans = s.OnesMinusZeros(grid);
        Console.WriteLine(ans);
    }
}