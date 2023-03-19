/*
 * Author: Deean
 * Date: 2023-03-19 08:57:02
 * FileName: P2367.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2367 {
    public class Solution {
        public int ArithmeticTriplets(int[] nums, int diff) {
            int cnt = 0, n = nums.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (nums[j] - nums[i] != diff) continue;
                    for (int k = j + 1; k < n; k++) {
                        if (nums[k] - nums[j] == diff) {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ArithmeticTriplets(new[] { 0, 1, 4, 6, 7, 10 }, 3);
        Console.WriteLine(ans);
    }
}