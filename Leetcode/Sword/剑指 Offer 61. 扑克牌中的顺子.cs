/*
 * Author: Deean
 * Date: 2023-05-21 10:33:00
 * FileName: 剑指 Offer 61. 扑克牌中的顺子.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_61__扑克牌中的顺子 {
    public class Solution {
        public bool IsStraight(int[] nums) {
            int zero = 0;
            foreach (var card in nums) {
                if (card == 0) zero++;
            }
            Array.Sort(nums);
            for (int i = zero; i < nums.Length - 1; i++) {
                if (nums[i] == nums[i + 1]) return false;
            }
            return nums[nums.Length - 1] - nums[zero] <= 4;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsStraight(new[] { 0, 0, 1, 2, 5 });
        Console.WriteLine(ans);
    }
}