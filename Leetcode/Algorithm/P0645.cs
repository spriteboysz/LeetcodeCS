/*
 * Author: Deean
 * Date: 2023-04-04 13:05:27
 * FileName: P0645.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0645 {
    public class Solution {
        public int[] FindErrorNums(int[] nums) {
            int n = nums.Length;
            int[] hash = new int[n + 1];
            foreach (var num in nums) {
                hash[num]++;
            }
            int repeat = -1, loss = -1;
            for (int i = 1; i <= n; i++) {
                if (hash[i] == 2) repeat = i;
                if (hash[i] == 0) loss = i;
            }
            return new[] { repeat, loss };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindErrorNums(new[] { 1, 2, 2, 4 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}