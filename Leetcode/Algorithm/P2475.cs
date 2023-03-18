/*
 * Author: Deean
 * Date: 2023-03-18 19:14:49
 * FileName: P2475.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2475 {
    public class Solution {
        public int UnequalTriplets(int[] nums) {
            int cnt = 0, n = nums.Length;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (nums[i] == nums[j]) continue;
                    for (int k = j + 1; k < n; k++) {
                        if (nums[i] != nums[k] && nums[j] != nums[k]) {
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
        var ans = s.UnequalTriplets(new[] { 4, 4, 2, 4, 3 });
        Console.WriteLine(ans);
    }
}