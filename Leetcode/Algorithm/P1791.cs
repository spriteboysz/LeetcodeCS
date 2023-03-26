/*
 * Author: Deean
 * Date: 2023-03-25 22:28:59
 * FileName: P1791.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1791 {
    public class Solution {
        public int FindCenter(int[][] edges) {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1]) {
                return edges[0][0];
            } else {
                return edges[0][1];
            }
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindCenter(lib.Arrays.To2DArray("[[1,2],[2,3],[4,2]]"));
        Console.WriteLine(ans);
    }
}