/*
 * Author: Deean
 * Date: 2023-03-22 22:55:57
 * FileName: P1995.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1995 {
    public class Solution {
        public int CountQuadruplets(int[] nums) {
            int cnt = 0, n = nums.Length;
            for (int a = 0; a < n; a++) {
                for (int b = a + 1; b < n; b++) {
                    for (int c = b + 1; c < n; c++) {
                        for (int d = c + 1; d < n; d++) {
                            if (nums[a] + nums[b] + nums[c] == nums[d]) {
                                cnt++;
                            }
                        }
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountQuadruplets(new[] { 1, 2, 3, 6 });
        Console.WriteLine(ans);
    }
}