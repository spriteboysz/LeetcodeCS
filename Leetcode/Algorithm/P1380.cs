/*
 * Author: Deean
 * Date: 2023-03-29 23:57:02
 * FileName: P1380.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1380 {
    public class Solution {
        public IList<int> LuckyNumbers(int[][] matrix) {
            int n = matrix.Length, m = matrix[0].Length;
            int[] rows = new int[n], cols = new int[m];
            for (int i = 0; i < n; i++) {
                rows[i] = Int32.MaxValue;
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    rows[i] = Math.Min(rows[i], matrix[i][j]);
                    cols[j] = Math.Max(cols[j], matrix[i][j]);
                }
            }

            IList<int> lucky = new List<int>();
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (matrix[i][j] == rows[i] && matrix[i][j] == cols[j]) {
                        lucky.Add(matrix[i][j]);
                    }
                }
            }
            return lucky;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LuckyNumbers(lib.Arrays.To2DArray("[[1,10,4,2],[9,3,8,7],[15,16,17,12]]"));
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}