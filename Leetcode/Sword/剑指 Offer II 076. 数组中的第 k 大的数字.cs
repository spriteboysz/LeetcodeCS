/*
 * Author: Deean
 * Date: 2023-05-27 23:09:40
 * FileName: 剑指 Offer II 076. 数组中的第 k 大的数字.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_076__数组中的第_k_大的数字 {
    public class Solution {
        public int FindKthLargest(int[] nums, int k) {
            Array.Sort(nums, (a, b) => b - a);
            return nums[k - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindKthLargest(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
        Console.WriteLine(ans);
    }
}