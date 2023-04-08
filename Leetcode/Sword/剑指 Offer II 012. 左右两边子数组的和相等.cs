/*
 * Author: Deean
 * Date: 2023-04-08 17:15:58
 * FileName: 剑指 Offer II 012. 左右两边子数组的和相等.cs
 * Description:
*/

using System;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_012__左右两边子数组的和相等 {
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