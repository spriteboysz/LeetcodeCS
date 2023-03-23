/*
 * Author: Deean
 * Date: 2023-03-23 23:25:38
 * FileName: P1929.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1929 {
    public class Solution {
        public int[] GetConcatenation(int[] nums) {
            return nums.Concat(nums).ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetConcatenation(new[] { 1, 3, 2, 1 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}