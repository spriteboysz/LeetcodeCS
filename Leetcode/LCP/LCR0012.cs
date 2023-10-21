/*
 * Author: Deean
 * Date: 2023-10-20 23:06:43
 * FileName: LCR0012.cs
 * Description: LCR 012. 寻找数组的中心下标
 */

using System;
using System.Linq;

namespace LCP;

public class LCR0012 {
    public class Solution {
        public int PivotIndex(int[] nums) {
            int acc = 0, sum = nums.Sum();
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (2 * acc + nums[i] == sum) {
                    return i;
                }
                acc += nums[i];
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 });
        Console.WriteLine(ans);
    }
}