/*
 * Author: Deean
 * Date: 2023-08-16 23:04:55
 * FileName: P2733.cs
 * Description:2733. 既不是最小值也不是最大值
 */

using System;
using System.Linq;

namespace Algorithm;

public class P2733 {
    public class Solution {
        public int FindNonMinOrMax(int[] nums) {
            int maximum = nums.Max(), minimum = nums.Min();
            foreach (var num in nums) {
                if (num != maximum && num != minimum) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindNonMinOrMax(new[] { 3, 2, 1, 4 });
        Console.WriteLine(ans);
    }
}