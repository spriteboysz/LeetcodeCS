/*
 * Author: Deean
 * Date: 2023-05-20 22:35:16
 * FileName: 剑指 Offer 47. 礼物的最大价值.cs
 * Description:
*/

using System;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_47__礼物的最大价值 {
    public class Solution {
        public int MaxValue(int[][] grid) {
            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[0].Length; j++) {
                    if (i == 0 && j == 0) {
                        continue;
                    }
                    if (i == 0) {
                        grid[i][j] += grid[i][j - 1];
                    } else if (j == 0) {
                        grid[i][j] += grid[i - 1][j];
                    } else {
                        grid[i][j] += Math.Max(grid[i - 1][j], grid[i][j - 1]);
                    }
                }
            }
            return grid.Last().Last();
        }
    }

    public static void Test() {
        var s = new Solution();
        var grid = Arrays.To2DArray("[[1,3,1],[1,5,1],[4,2,1]]");
        var ans = s.MaxValue(grid);
        Console.WriteLine(ans);
    }
}