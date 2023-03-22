/*
 * Author: Deean
 * Date: 2023-03-21 22:45:46
 * FileName: P2144.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2144 {
    public class Solution {
        public int MinimumCost(int[] cost) {
            Array.Sort(cost, (a, b) => b - a);
            int sum = 0, n = cost.Length;
            for (int i = 0; i < n; i += 3) {
                sum += cost[i];
                if (i + 1 < n) {
                    sum += cost[i + 1];
                }
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumCost(new[] { 6, 5, 7, 9, 2, 2 });
        Console.WriteLine(ans);
    }
}