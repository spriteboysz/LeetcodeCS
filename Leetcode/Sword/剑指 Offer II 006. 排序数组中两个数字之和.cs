/*
 * Author: Deean
 * Date: 2023-04-08 17:10:14
 * FileName: 剑指 Offer II 006. 排序数组中两个数字之和.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_006__排序数组中两个数字之和 {
    public class Solution {
        public int[] TwoSum(int[] numbers, int target) {
            int left = 0, right = numbers.Length - 1;
            while (left < right) {
                if (numbers[left] + numbers[right] > target) {
                    right--;
                } else if (numbers[left] + numbers[right] < target) {
                    left++;
                } else {
                    return new[] { left, right };
                }
            }
            return new[] { -1, -1 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TwoSum(new[] { 1, 2, 4, 6, 10 }, 8);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}