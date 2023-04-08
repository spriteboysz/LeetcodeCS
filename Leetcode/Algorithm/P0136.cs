/*
 * Author: Deean
 * Date: 2023-04-08 09:25:08
 * FileName: P0136.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0136 {
    public class Solution {
        public int SingleNumber(int[] nums) {
            int single = 0;
            foreach (var num in nums) {
                single ^= num;
            }
            return single;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNumber(new[] { 2, 2, 1 });
        Console.WriteLine(ans);
    }
}