/*
 * Author: Deean
 * Date: 2023-05-20 14:43:24
 * FileName: P2643.cs
 * Description:
*/

using System;
using System.Linq;
using lib;

namespace Algorithm;

public class P2643 {
    public class Solution {
        public int[] RowAndMaximumOnes(int[][] mat) {
            int max_index = 0, max_value = mat[0].Sum();
            for (int i = 1; i < mat.Length; i++) {
                int val = mat[i].Sum();
                if (val > max_value) {
                    max_index = i;
                    max_value = val;
                }
            }
            return new[] { max_index, max_value };
        }
    }

    public static void Test() {
        var s = new Solution();
        var mat = Arrays.To2DArray("[[0,0,0],[0,1,1]]");
        var ans = s.RowAndMaximumOnes(mat);
        Console.WriteLine(Arrays.ToString(ans));
    }
}