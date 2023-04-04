/*
 * Author: Deean
 * Date: 2023-04-04 15:16:36
 * FileName: P0704.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0704 {
    public class Solution {
        public int Search(int[] nums, int target) {
            int left = 0, right = nums.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target) {
                    left = mid + 1;
                } else if (nums[mid] > target) {
                    right = mid - 1;
                } else {
                    return mid;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Search(new[] { -1, 0, 3, 5, 9, 12 }, 9);
        Console.WriteLine(ans);
    }
}