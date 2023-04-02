/*
 * Author: Deean
 * Date: 2023-04-01 22:41:47
 * FileName: P1217.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1217 {
    public class Solution {
        public int MinCostToMoveChips(int[] position) {
            int even = 0, odd = 0;
            foreach (var pos in position) {
                if (pos % 2 == 0) {
                    even++;
                } else {
                    odd++;
                }
            }
            return Math.Min(even, odd);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinCostToMoveChips(new[] { 2, 2, 2, 3, 3 });
        Console.WriteLine(ans);
    }
}