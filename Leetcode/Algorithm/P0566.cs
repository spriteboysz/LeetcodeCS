/*
 * Author: Deean
 * Date: 2023-04-05 17:05:24
 * FileName: P0566.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0566 {
    public class Solution {
        public int[][] MatrixReshape(int[][] mat, int r, int c) {
            int n = mat.Length, m = mat[0].Length;
            if (m * n != r * c) return mat;
            int[][] mat2 = new int[r][];
            for (int i = 0; i < r; i++) {
                mat2[i] = new int[c];
            }
            for (int i = 0, pos = 0; i < r; i++) {
                for (int j = 0; j < c; j++) {
                    mat2[i][j] = mat[pos / m][pos % m];
                    pos++;
                }
            }
            return mat2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MatrixReshape(lib.Arrays.To2DArray("[[1,2],[3,4]]"), 1, 4);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}