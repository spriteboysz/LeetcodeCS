/*
 * Author: Deean
 * Date: 2023-04-08 21:57:26
 * FileName: 面试题61. 扑克牌中的顺子.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题61__扑克牌中的顺子 {
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
        var ans = s.IsStraight(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine(ans);
    }
}