/*
 * Author: Deean
 * Date: 2023-04-02 16:59:22
 * FileName: P0997.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0997 {
    public class Solution {
        public int FindJudge(int n, int[][] trust) {
            int[] ingress = new int[n + 1], egress = new int[n + 1];
            foreach (var edge in trust) {
                ingress[edge[1]]++;
                egress[edge[0]]++;
            }
            for (int i = 1; i <= n; i++) {
                if (ingress[i] == n - 1 && egress[i] == 0) {
                    return i;
                }
            }
            return -1;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindJudge(3, lib.Arrays.To2DArray("[[1,3],[2,3]]"));
        Console.WriteLine(ans);
    }
}