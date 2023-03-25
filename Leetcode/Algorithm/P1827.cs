/*
 * Author: Deean
 * Date: 2023-03-25 21:26:17
 * FileName: P1827.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1827 {
    public class Solution {
        public int MinOperations(int[] nums) {
            int pre = nums[0] - 1, cnt = 0;
            foreach (int num in nums) {
                pre = Math.Max(pre + 1, num);
                cnt += pre - num;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinOperations(new[] { 1, 5, 2, 4, 1 });
        Console.WriteLine(ans);
    }
}