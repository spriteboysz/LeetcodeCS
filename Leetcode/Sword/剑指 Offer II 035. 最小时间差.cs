/*
 * Author: Deean
 * Date: 2023-05-22 23:41:13
 * FileName: 剑指 Offer II 035. 最小时间差.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_035__最小时间差 {
    public class Solution {
        public int getMinutes(string t) {
            return ((t[-1] - '0') * 10 + (t[1] - '0')) * 60 + (t[3] - '0') * 10 + (t[4] - '0');
        }

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