/*
 * Author: Deean
 * Date: 2023-03-31 23:12:19
 * FileName: P1252.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1252 {
    public class Solution {
        public int OddCells(int m, int n, int[][] indices) {
            int[,] matrix = new int[m, n];
            foreach (var index in indices) {
                for (int i = 0; i < n; i++) {
                    matrix[index[0], i]++;
                }
                for (int i = 0; i < m; i++) {
                    matrix[i, index[1]]++;
                }
            }
            int cnt = 0;
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i, j] % 2 == 1) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.OddCells(2, 3, lib.Arrays.To2DArray("[[0,1],[1,1]]"));
        Console.WriteLine(ans);
    }
}