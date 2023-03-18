/*
 * Author: Deean
 * Date: 2023-03-18 22:26:57
 * FileName: P2432.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2432 {
    public class Solution {
        public int HardestWorker(int n, int[][] logs) {
            int index = 0, maximum = logs[0][1] - 0;
            for (int i = 1; i < logs.Length; i++) {
                int cur = logs[i][1] - logs[i - 1][1];
                if (cur > maximum) {
                    index = i;
                    maximum = cur;
                } else if (cur == maximum) {
                    index = logs[i][0] < logs[index][0] ? i : index;
                }
            }
            return logs[index][0];
        }
    }

    public static void Test() {
        var s = new Solution();
        int[][] logs = new int [4][];
        logs[0] = new[] { 0, 3 };
        logs[1] = new[] { 2, 5 };
        logs[2] = new[] { 0, 9 };
        logs[3] = new[] { 1, 15 };
        var ans = s.HardestWorker(10, logs);
        Console.WriteLine(ans);
    }
}