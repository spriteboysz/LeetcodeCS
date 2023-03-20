/*
 * Author: Deean
 * Date: 2023-03-19 22:25:31
 * FileName: P2073.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2073 {
    public class Solution {
        public int TimeRequiredToBuy(int[] tickets, int k) {
            int cnt = 0;
            for (int i = 0; i <= k; i++) {
                cnt += Math.Min(tickets[k], tickets[i]);
            }
            for (int i = k + 1; i < tickets.Length; i++) {
                cnt += Math.Min(tickets[k] - 1, tickets[i]);
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TimeRequiredToBuy(new[] { 2, 3, 2 }, 2);
        Console.WriteLine(ans);
    }
}