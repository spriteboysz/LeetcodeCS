/*
 * Author: Deean
 * Date: 2023-04-08 16:18:13
 * FileName: P0034.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0034 {
    public class Solution {
        public int[] SearchRange(int[] nums, int target) {
            int start = -1, end = -1;
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (start == -1 && nums[i] == target) {
                    start = i;
                    end = i;
                } else if (nums[i] == target) {
                    end = i;
                }
            }
            return new[] { start, end };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SearchRange(new[] { 5, 7, 7, 8, 8, 10 }, 8);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}