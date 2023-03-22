/*
 * Author: Deean
 * Date: 2023-03-21 23:05:49
 * FileName: P2164.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2164 {
    public class Solution {
        public int[] SortEvenOdd(int[] nums) {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                if (i % 2 == 0) {
                    even.Add(nums[i]);
                } else {
                    odd.Add(nums[i]);
                }
            }
            even.Sort();
            odd.Sort((a, b) => b - a);
            int pos1 = 0, pos2 = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (i % 2 == 0) {
                    nums[i] = even[pos1++];
                } else {
                    nums[i] = odd[pos2++];
                }
            }
            return nums;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortEvenOdd(new[] { 4, 1, 2, 3 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}