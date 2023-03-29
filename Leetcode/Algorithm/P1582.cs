/*
 * Author: Deean
 * Date: 2023-03-29 22:31:11
 * FileName: P1582.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1582 {
    public class Solution {
        public int NumSpecial(int[][] mat) {
            int n = mat.Length, m = mat[0].Length;
            int[] rows = new int[n], cols = new int[m];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    rows[i] += mat[i][j];
                    cols[j] += mat[i][j];
                }
            }
            int cnt = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i][j] == 1 && rows[i] == 1 && cols[j] == 1) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumSpecial(lib.Arrays.To2DArray("[[1,0,0],[0,1,0],[0,0,1]]"));
        Console.WriteLine(ans);
    }
}