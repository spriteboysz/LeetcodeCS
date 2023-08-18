/*
 * Author: Deean
 * Date: 2023-08-16 23:08:43
 * FileName: P2739.cs
 * Description:2739. 总行驶距离
 */

using System;

namespace Algorithm;

public class P2739 {
    public class Solution {
        public int DistanceTraveled(int mainTank, int additionalTank) {
            int n = Math.Min((mainTank - 1) >> 2, additionalTank);
            return (mainTank + n) * 10;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistanceTraveled(5, 10);
        Console.WriteLine(ans);
    }
}