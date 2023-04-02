/*
 * Author: Deean
 * Date: 2023-04-02 16:28:22
 * FileName: P1005.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1005 {
    public class Solution {
        public int LargestSumAfterKNegations(int[] nums, int k) {
            Array.Sort(nums);
            int n = nums.Length, last = -1;
            for (int i = 0; i < n && nums[i] < 0 && k > 0; i++, k--) {
                last = i;
                nums[i] *= -1;
            }
            if (k > 0 && k % 2 == 1) {
                int minIndex;
                if (last < 0) {
                    minIndex = 0;
                } else if (last == n - 1) {
                    minIndex = n - 1;
                } else {
                    minIndex = nums[last] <= nums[last + 1] ? last : last + 1;
                }
                nums[minIndex] *= -1;
            }
            return nums.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestSumAfterKNegations(new[] { 2, -3, -1, 5, -4 }, 2);
        Console.WriteLine(ans);
    }
}