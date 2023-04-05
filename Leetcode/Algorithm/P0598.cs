/*
 * Author: Deean
 * Date: 2023-04-05 17:43:22
 * FileName: P0598.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0598 {
    public class Solution {
        public int MaxCount(int m, int n, int[][] ops) {
            int mina = m, minb = n;
            foreach (int[] op in ops) {
                mina = Math.Min(mina, op[0]);
                minb = Math.Min(minb, op[1]);
            }
            return mina * minb;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxCount(3, 3, lib.Arrays.To2DArray("[[2,2],[3,3]]"));
        Console.WriteLine(ans);
    }
}