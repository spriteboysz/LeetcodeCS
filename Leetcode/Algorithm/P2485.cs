/*
 * Author: Deean
 * Date: 2023-03-18 19:10:22
 * FileName: P2485.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2485 {
    public class Solution {
        public int PivotInteger(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                if (i * (i + 1) / 2 == n * (n + 1) / 2 - sum) {
                    return i;
                }
                sum += i;
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PivotInteger(8);
        Console.WriteLine(ans);
    }
}