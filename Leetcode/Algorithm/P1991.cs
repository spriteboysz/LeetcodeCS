/*
 * Author: Deean
 * Date: 2023-03-22 22:59:06
 * FileName: P1991.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1991 {
    public class Solution {
        public int FindMiddleIndex(int[] nums) {
            int left = 0, right = nums.Sum();
            for (int i = 0; i < nums.Length; i++) {
                if (left + nums[i] == right) {
                    return i;
                }
                left += nums[i];
                right -= nums[i];
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMiddleIndex(new[] { 2, 3, -1, 8, 4 });
        Console.WriteLine(ans);
    }
}