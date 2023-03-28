/*
 * Author: Deean
 * Date: 2023-03-28 23:16:07
 * FileName: P1572.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1572 {
    public class Solution {
        public int DiagonalSum(int[][] mat) {
            int sum = 0, n = mat.Length;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j || i + j == n - 1) {
                        sum += mat[i][j];
                    }
                }
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DiagonalSum(lib.Arrays.To2DArray("[[1,2,3],[4,5,6],[7,8,9]]"));
        Console.WriteLine(ans);
    }
}