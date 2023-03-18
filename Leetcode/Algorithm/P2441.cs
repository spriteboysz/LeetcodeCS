/*
 * Author: Deean
 * Date: 2023-03-18 21:35:23
 * FileName: P2441.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2441 {
    public class Solution {
        public int FindMaxK(int[] nums) {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            while (left < right) {
                if (nums[left] + nums[right] < 0) {
                    left++;
                } else if (nums[left] + nums[right] > 0) {
                    right--;
                } else {
                    return nums[right];
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMaxK(new[] { -1, 10, 6, 7, -7, 1 });
        Console.WriteLine(ans);
    }
}