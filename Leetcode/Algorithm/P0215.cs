/*
 * Author: Deean
 * Date: 2023-05-27 23:11:48
 * FileName: P0215.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0215 {
    public class Solution {
        public int FindKthLargest(int[] nums, int k) {
            Array.Sort(nums, (a, b) => b - a);
            return nums[k - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindKthLargest(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
        Console.WriteLine(ans);
    }
}