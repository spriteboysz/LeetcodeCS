/*
 * Author: Deean
 * Date: 2023-08-16 22:33:28
 * FileName: P2769.cs
 * Description:2769. 找出最大的可达成数字
 */

using System;

namespace Algorithm;

public class P2769 {
    public class Solution {
        public int TheMaximumAchievableX(int num, int t) {
            return num + t * 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TheMaximumAchievableX(4, 1);
        Console.WriteLine(ans);
    }
}