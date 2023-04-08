/*
 * Author: Deean
 * Date: 2023-04-08 11:10:14
 * FileName: P0035.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0035 {
    public class Solution {
        public int SearchInsert(int[] nums, int target) {
            int left = 0, right = nums.Length - 1, mid = 0;
            while (left <= right) {
                mid = (left + right) / 2;
                if (target == nums[mid]) {
                    return mid;
                }
                if (target > nums[mid]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            return target > nums[mid] ? mid + 1 : mid;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SearchInsert(new[] { 1, 3, 5, 6 }, 2);
        Console.WriteLine(ans);
    }
}