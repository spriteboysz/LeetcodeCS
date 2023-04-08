/*
 * Author: Deean
 * Date: 2023-04-08 16:39:36
 * FileName: 剑指 Offer 57. 和为s的两个数字.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_57__和为s的两个数字 {
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            HashSet<int> seen = new HashSet<int>();
            foreach (var num in nums) {
                if (seen.Contains(target - num)) {
                    return new[] { num, target - num };
                }
                seen.Add(num);
            }
            return new[] { -1, -1 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}