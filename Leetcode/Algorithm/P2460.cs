/*
 * Author: Deean
 * Date: 2023-03-18 19:29:44
 * FileName: P2460.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2460 {
    public class Solution {
        public int[] ApplyOperations(int[] nums) {
            int pos = 0, n = nums.Length;
            for (int i = 0; i < n - 1; i++) {
                if (nums[i] != 0) {
                    if (nums[i] == nums[i + 1]) {
                        nums[i] *= 2;
                        nums[i + 1] = 0;
                    }
                    nums[pos++] = nums[i];
                }
            }
            if (nums[n - 1] != 0) {
                nums[pos++] = nums[n - 1];
            }
            for (int i = pos; i < n; i++) {
                nums[i] = 0;
            }
            return nums;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ApplyOperations(new[] { 1, 2, 2, 1, 1, 0 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}