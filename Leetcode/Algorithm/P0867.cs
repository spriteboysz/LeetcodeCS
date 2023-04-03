/*
 * Author: Deean
 * Date: 2023-04-02 21:34:55
 * FileName: P0867.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0867 {
    public class Solution {
        public int[][] Transpose(int[][] matrix) {
            int n = matrix.Length, m = matrix[0].Length;
            int[][] matrix2 = new int[m][];
            for (int i = 0; i < m; i++) {
                matrix2[i] = new int[n];
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    matrix2[j][i] = matrix[i][j];
                }
            }
            return matrix2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Transpose(lib.Arrays.To2DArray("[[1,2,3],[4,5,6],[7,8,9]]"));
        Console.WriteLine(ans);
    }
}