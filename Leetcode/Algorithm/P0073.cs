/*
 * Author: Deean
 * Date: 2023-05-31 23:25:23
 * FileName: P0073.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0073 {
    public class Solution {
        public void SetZeroes(int[][] matrix) {
            int m = matrix.Length, n = matrix[0].Length;
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i][j] == 0) {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (rows.Contains(i) || cols.Contains(j)) {
                        matrix[i][j] = 0;
                    }
                }
            }
            for (int i = 0; i < m; i++) {
                Console.WriteLine(Arrays.ToString(matrix[i]));
            }
        }
    }

    public static void Test() {
        var matrix = Arrays.To2DArray("[[1,1,1],[1,0,1],[1,1,1]]");
        var s = new Solution();
        s.SetZeroes(matrix);
    }
}