/*
 * Author: Deean
 * Date: 2023-03-26 22:33:06
 * FileName: P1752.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1752 {
    public class Solution {
        public bool Check(int[] nums) {
            int n = nums.Length, x = 0;
            for (int i = 1; i < n; i++) {
                if (nums[i] < nums[i - 1]) {
                    x = i;
                    break;
                }
            }
            if (x == 0) return true;
            for (int i = x + 1; i < n; i++) {
                if (nums[i] < nums[i - 1]) {
                    return false;
                }
            }
            return nums[0] >= nums[n - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Check(new[] { 3, 4, 5, 1, 2 });
        Console.WriteLine(ans);
    }
}