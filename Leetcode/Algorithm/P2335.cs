/*
 * Author: Deean
 * Date: 2023-03-19 09:59:28
 * FileName: P2335.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2335 {
    public class Solution {
        public int FillCups(int[] amount) {
            Array.Sort(amount);
            if (amount[2] > amount[0] + amount[1]) {
                return amount[2];
            }
            return (amount.Sum() + 1) / 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FillCups(new[] { 1, 4, 2 });
        Console.WriteLine(ans);
    }
}