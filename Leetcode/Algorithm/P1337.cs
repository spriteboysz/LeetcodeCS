/*
 * Author: Deean
 * Date: 2023-03-30 23:50:16
 * FileName: P1337.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1337 {
    public class Solution {
        public int[] KWeakestRows(int[][] mat, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++) {
                dict.Add(i, mat[i].Sum());
            }

            return dict.OrderBy(t => t.Value).Select(t => t.Key).Take(k).ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KWeakestRows(lib.Arrays.To2DArray("[[1,1,0,0,0],[1,1,1,1,0],[1,0,0,0,0],[1,1,0,0,0],[1,1,1,1,1]]"),
            3);
        Console.WriteLine(ans);
    }
}