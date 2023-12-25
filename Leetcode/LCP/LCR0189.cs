/*
 * Author: Deean
 * Date: 2023-12-25 22:48:30
 * FileName: LCR0189.cs
 * Description: LCR 189. 设计机械累加器
 */

using System;

namespace LCP;

public class LCR0189 {
    public class Solution {
        public int MechanicalAccumulator(int target) {
            if (target == 1) return 1;
            return MechanicalAccumulator(target - 1) + target;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MechanicalAccumulator(5);
        Console.WriteLine(ans);
    }
}