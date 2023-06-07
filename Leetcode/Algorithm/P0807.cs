/*
 * Author: Deean
 * Date: 2023-06-06 22:59:25
 * FileName: P0807.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0807 {
    public class Solution {
        public int MaxIncreaseKeepingSkyline(int[][] grid) {
            int n = grid.Length;
            int[] rows = new int[n], cols = new int[n];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    rows[i] = Math.Max(rows[i], grid[i][j]);
                    cols[j] = Math.Max(cols[j], grid[i][j]);
                }
            }
            int cnt = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    cnt += Math.Min(rows[i], cols[j]) - grid[i][j];
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var grid = Arrays.To2DArray("[[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]]");
        var s = new Solution();
        var ans = s.MaxIncreaseKeepingSkyline(grid);
        Console.WriteLine(ans);
    }
}