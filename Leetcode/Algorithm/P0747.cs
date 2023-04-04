/*
 * Author: Deean
 * Date: 2023-04-04 11:49:12
 * FileName: P0747.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0747 {
    public class Solution {
        public int DominantIndex(int[] nums) {
            int max1 = -1, max2 = -1, index = -1;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max1) {
                    max2 = max1;
                    max1 = nums[i];
                    index = i;
                } else if (nums[i] > max2) {
                    max2 = nums[i];
                }
            }
            return max1 >= max2 * 2 ? index : -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DominantIndex(new[] { 3, 6, 1, 0 });
        Console.WriteLine(ans);
    }
}