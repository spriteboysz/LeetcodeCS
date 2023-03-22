/*
 * Author: Deean
 * Date: 2023-03-21 23:28:01
 * FileName: P2176.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2176 {
    public class Solution {
        public int CountPairs(int[] nums, int k) {
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] == nums[j] && (i * j) % k == 0) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountPairs(new[] { 3, 1, 2, 2, 2, 1, 3 }, 2);
        Console.WriteLine(ans);
    }
}