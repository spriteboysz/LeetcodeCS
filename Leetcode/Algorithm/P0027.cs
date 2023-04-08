/*
 * Author: Deean
 * Date: 2023-04-08 11:17:42
 * FileName: P0027.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0027 {
    public class Solution {
        public int RemoveElement(int[] nums, int val) {
            int n = nums.Length, fast = 0, slow = 0;
            while (fast < n) {
                if (nums[fast] != val) {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            Console.WriteLine(lib.Arrays.ToString(nums));
            return slow;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        Console.WriteLine(ans);
    }
}