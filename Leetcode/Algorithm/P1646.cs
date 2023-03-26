/*
 * Author: Deean
 * Date: 2023-03-26 10:53:04
 * FileName: P1646.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1646 {
    public class Solution {
        public int GetMaximumGenerated(int n) {
            int[] nums = new int[102];
            for (int i = 0; i <= n; i++) {
                if (i <= 1) {
                    nums[i] = i;
                } else {
                    if (i % 2 == 0) {
                        nums[i] = nums[i / 2];
                    } else {
                        nums[i] = nums[i / 2] + nums[i / 2 + 1];
                    }
                }
            }
            return nums.Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetMaximumGenerated(7);
        Console.WriteLine(ans);
    }
}