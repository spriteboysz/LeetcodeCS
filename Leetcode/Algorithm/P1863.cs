/*
 * Author: Deean
 * Date: 2023-03-25 22:09:48
 * FileName: P1863.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1863 {
    public class Solution {
        public int SubsetXORSum(int[] nums) {
            int sum = 0, n = nums.Length;
            for (int i = 0; i < n; i++) {
                sum |= nums[i];
            }
            return sum << (n - 1);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SubsetXORSum(new[] { 3, 4, 5, 6, 7, 8 });
        Console.WriteLine(ans);
    }
}