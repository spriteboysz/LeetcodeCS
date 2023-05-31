/*
 * Author: Deean
 * Date: 2023-05-31 23:13:31
 * FileName: P0048.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0048 {
    public class Solution {
        public void Rotate(int[][] matrix) {
            int n = matrix.Length;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < i; j++) {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n / 2; j++) {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - 1 - j];
                    matrix[i][n - 1 - j] = temp;
                }
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine(Arrays.ToString(matrix[i]));
            }
        }
    }

    public static void Test() {
        var matrix = Arrays.To2DArray("[[1,2,3],[4,5,6],[7,8,9]]");
        var s = new Solution();
        s.Rotate(matrix);
    }
}