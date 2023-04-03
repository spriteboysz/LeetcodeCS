/*
 * Author: Deean
 * Date: 2023-04-02 22:32:56
 * FileName: P0896.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0896 {
    public class Solution {
        public bool IsMonotonic(int[] nums) {
            int a = 0, b = 0;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i - 1] < nums[i]) a = 1;
                if (nums[i - 1] > nums[i]) b = 1;
            }
            return a + b != 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsMonotonic(new[] { 1, 2, 2, 3 });
        Console.WriteLine(ans);
    }
}