﻿/*
 * Author: Deean
 * Date: 2023-10-22 21:56:46
 * FileName: LCR0035.cs
 * Description: LCR 035. 最小时间差
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP; 

public class LCR0035 {
    public class Solution {
        public int FindMinDifference(IList<string> timePoints) {
            timePoints = timePoints.OrderBy(x => x).ToList();
            int ans = int.MaxValue;
            int t0Minutes = getMinutes(timePoints[0]);
            int preMinutes = t0Minutes;
            for (int i = 1; i < timePoints.Count; ++i) {
                int minutes = getMinutes(timePoints[i]);
                ans = Math.Min(ans, minutes - preMinutes); // 相邻时间的时间差
                preMinutes = minutes;
            }
            ans = Math.Min(ans, t0Minutes + 1440 - preMinutes); // 首尾时间的时间差
            return ans;
        }

        public int getMinutes(string t) {
            return ((t[0] - '0') * 10 + (t[1] - '0')) * 60 + (t[3] - '0') * 10 + (t[4] - '0');
        }
    }

    public static void Test() {
        var s = new Solution();
        List<string> timePoints = new List<string> {
            "23:59",
            "00:00"
        };
        var ans = s.FindMinDifference(timePoints);
        Console.WriteLine(ans);
    }
}