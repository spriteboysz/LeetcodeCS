/*
 * Author: Deean
 * Date: 2023-05-31 23:17:30
 * FileName: 面试题 01.08. 零矩阵.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview;

public class 面试题_01_08__零矩阵 {
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