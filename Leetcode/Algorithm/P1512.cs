/*
 * Author: Deean
 * Date: 2023-03-27 23:25:02
 * FileName: P1512.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1512 {
    public class Solution {
        public int NumIdenticalPairs(int[] nums) {
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] == nums[j]) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumIdenticalPairs(new[] { 1, 2, 3, 1, 1, 3 });
        Console.WriteLine(ans);
    }
}