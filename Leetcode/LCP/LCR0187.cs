/*
 * Author: Deean
 * Date: 2023-12-23 20:06:04
 * FileName: LCR0187.cs
 * Description: LCR 187. 破冰游戏
 */

using System;

namespace LCP;

public class LCR0187 {
    public class Solution {
        public int IceBreakingGame(int num, int target) {
            if (num == 1) return 0;
            int prev = IceBreakingGame(num - 1, target);
            return (prev + target) % num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IceBreakingGame(7, 4);
        Console.WriteLine(ans);
    }
}