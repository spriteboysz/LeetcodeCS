/*
 * Author: Deean
 * Date: 2023-04-07 22:46:53
 * FileName: P0219.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0219 {
    public class Solution {
        public bool ContainsNearbyDuplicate(int[] nums, int k) {
            for (int i = 0, n = nums.Length; i < n; i++) {
                for (int j = i + 1; j <= i + k && j < n; j++) {
                    if (nums[i] == nums[j]) {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3);
        Console.WriteLine(ans);
    }
}