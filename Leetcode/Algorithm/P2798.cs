/*
 * Author: Deean
 * Date: 2023-08-16 21:46:44
 * FileName: P2798.cs
 * Description:2798. 满足目标工作时长的员工数目
 */

using System;
using System.Linq;

namespace Algorithm;

public class P2798 {
    public class Solution {
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
            return hours.Count(hour => hour >= target);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfEmployeesWhoMetTarget(new[] { 0, 1, 2, 3, 4 }, 2);
        Console.WriteLine(ans);
    }
}