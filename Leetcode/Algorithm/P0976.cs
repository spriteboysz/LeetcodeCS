/*
 * Author: Deean
 * Date: 2023-04-02 19:21:41
 * FileName: P0976.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0976 {
    public class Solution {
        public int LargestPerimeter(int[] nums) {
            Array.Sort(nums, (a, b) => b - a);
            int n = nums.Length;
            for (int i = 2; i < n; i++) {
                if (nums[i - 2] < nums[i - 1] + nums[i]) {
                    return nums[i - 2] + nums[i - 1] + nums[i];
                }
            }
            return 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestPerimeter(new[] { 1, 2, 1, 10 });
        Console.WriteLine(ans);
    }
}