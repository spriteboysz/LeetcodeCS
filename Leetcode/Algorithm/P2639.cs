/*
 * Author: Deean
 * Date: 2023-05-19 23:15:03
 * FileName: P2639.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P2639 {
    public class Solution {
        public int[] FindColumnWidth(int[][] grid) {
            IList<int> width = new List<int>();
            for (int j = 0; j < grid[0].Length; j++) {
                int maximum = 0;
                for (int i = 0; i < grid.Length; i++) {
                    maximum = Math.Max(maximum, grid[i][j].ToString().Length);
                }
                width.Add(maximum);
            }
            return width.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var grid = Arrays.To2DArray("[[-15,1,3],[15,7,12],[5,6,-2]]");
        var ans = s.FindColumnWidth(grid);
        Console.WriteLine(Arrays.ToString(ans));
    }
}