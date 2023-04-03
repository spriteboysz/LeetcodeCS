/*
 * Author: Deean
 * Date: 2023-04-03 22:58:27
 * FileName: P0908.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0908 {
    public class Solution {
        public int SmallestRangeI(int[] nums, int k) {
            int min = nums.Min(), max = nums.Max();
            return Math.Max(0, max - k - (min + k));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SmallestRangeI(new[] { 0, 10 }, 2);
        Console.WriteLine(ans);
    }
}