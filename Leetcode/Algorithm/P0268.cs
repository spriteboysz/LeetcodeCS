/*
 * Author: Deean
 * Date: 2023-04-06 23:50:36
 * FileName: P0268.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0268 {
    public class Solution {
        public int MissingNumber(int[] nums) {
            int n = nums.Length;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MissingNumber(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        Console.WriteLine(ans);
    }
}