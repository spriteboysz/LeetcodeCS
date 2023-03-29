/*
 * Author: Deean
 * Date: 2023-03-28 23:38:33
 * FileName: P1608.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1608 {
    public class Solution {
        public int SpecialArray(int[] nums) {
            Array.Sort(nums, (a, b) => b - a);
            int n = nums.Length;
            for (int i = 1; i <= n; i++) {
                if (nums[i - 1] >= i && (i == n || nums[i] < i)) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SpecialArray(new[] { 0, 4, 3, 0, 4 });
        Console.WriteLine(ans);
    }
}