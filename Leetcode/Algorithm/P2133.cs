/*
 * Author: Deean
 * Date: 2023-03-20 23:42:00
 * FileName: P2133.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2133 {
    public class Solution {
        public bool CheckValid(int[][] matrix) {
            int n = matrix.Length;
            for (int i = 0; i < n; i++) {
                HashSet<int> rows = new HashSet<int>();
                HashSet<int> cols = new HashSet<int>();
                for (int j = 0; j < n; j++) {
                    if (rows.Contains(matrix[i][j]) || cols.Contains(matrix[j][i])) {
                        return false;
                    }
                    rows.Add(matrix[i][j]);
                    cols.Add(matrix[j][i]);
                }
            }
            return true;
        }
    }

    public static void Test() {
        int[][] matrix = new int[3][];
        matrix[0] = new[] { 1, 2, 3 };
        matrix[1] = new[] { 3, 1, 2 };
        matrix[2] = new[] { 2, 3, 1 };
        var s = new Solution();
        var ans = s.CheckValid(matrix);
        Console.WriteLine(ans);
    }
}