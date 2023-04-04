/*
 * Author: Deean
 * Date: 2023-04-04 11:13:17
 * FileName: P0766.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0766 {
    public class Solution {
        public bool IsToeplitzMatrix(int[][] matrix) {
            int n = matrix.Length, m = matrix[0].Length;
            if (m == 1 || n == 1) return true;
            for (int i = 1; i < n; i++) {
                for (int j = 1; j < m; j++) {
                    if (matrix[i][j] != matrix[i - 1][j - 1]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsToeplitzMatrix(lib.Arrays.To2DArray("[[1,2,3,4],[5,1,2,3],[9,5,1,2]]"));
        Console.WriteLine(ans);
    }
}