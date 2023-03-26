/*
 * Author: Deean
 * Date: 2023-03-26 13:44:37
 * FileName: P1672.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P1672 {
    public class Solution {
        public int MaximumWealth(int[][] accounts) {
            int maximum = -1;
            foreach (var account in accounts) {
                maximum = Math.Max(maximum, account.Sum());
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumWealth(lib.Arrays.To2DArray("[[1,5],[7,3],[3,5]]"));
        Console.WriteLine(ans);
    }
}