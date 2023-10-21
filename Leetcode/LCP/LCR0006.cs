/*
 * Author: Deean
 * Date: 2023-10-20 23:04:18
 * FileName: LCR0006.cs
 * Description: LCR 006. 两数之和 II - 输入有序数组
 */

using System;
using lib;

namespace LCP;

public class LCR0006 {
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
        Console.WriteLine(Arrays.ToString(ans));
    }
}