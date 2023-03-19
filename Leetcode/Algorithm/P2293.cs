/*
 * Author: Deean
 * Date: 2023-03-19 11:11:02
 * FileName: P2293.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2293 {
    public class Solution {
        public int MinMaxGame(int[] nums) {
            int n = nums.Length;
            while (n > 1) {
                int[] nums2 = new int[n / 2];
                for (int i = 0; i < nums2.Length; i++) {
                    if (i % 2 == 0) {
                        nums2[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                    } else {
                        nums2[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                    }
                }
                nums = nums2;
                n >>= 1;
            }
            return nums[0];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinMaxGame(new[] { 1, 3, 5, 2, 4, 8, 2, 2 });
        Console.WriteLine(ans);
    }
}