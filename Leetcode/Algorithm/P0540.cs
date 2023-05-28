/*
 * Author: Deean
 * Date: 2023-05-28 10:23:13
 * FileName: P0540.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0540 {
    public class Solution {
        public int SingleNonDuplicate(int[] nums) {
            int left = 0, right = nums.Length - 1;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == nums[mid ^ 1]) {
                    left = mid + 1;
                } else {
                    right = mid;
                }
            }
            return nums[left];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNonDuplicate(new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 });
        Console.WriteLine(ans);
    }
}