/*
 * Author: Deean
 * Date: 2023-03-19 21:59:17
 * FileName: P2057.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2057 {
    public class Solution {
        public int SmallestEqual(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                if (i % 10 == nums[i]) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SmallestEqual(new[] { 4, 3, 2, 1 });
        Console.WriteLine(ans);
    }
}