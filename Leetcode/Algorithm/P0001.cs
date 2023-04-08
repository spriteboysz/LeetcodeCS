/*
 * Author: Deean
 * Date: 2023-04-08 12:18:23
 * FileName: P0001.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0001 {
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (dict.ContainsKey(target - nums[i])) {
                    return new[] { dict[target - nums[i]], i };
                }
                dict[nums[i]] = i;
            }
            return new[] { -1, -1 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}