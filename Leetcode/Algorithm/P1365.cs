/*
 * Author: Deean
 * Date: 2023-03-30 22:59:23
 * FileName: P1365.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1365 {
    public class Solution {
        public int[] SmallerNumbersThanCurrent(int[] nums) {
            int n = nums.Length;
            int[] nums2 = new int[n];
            for (int i = 0; i < n; i++) {
                nums2[i] = nums[i];
            }
            Array.Sort(nums2);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++) {
                if (!dict.ContainsKey(nums2[i])) {
                    dict.Add(nums2[i], i);
                }
            }
            for (int i = 0; i < n; i++) {
                nums2[i] = dict[nums[i]];
            }
            return nums2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SmallerNumbersThanCurrent(new[] { 8, 1, 2, 2, 3 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}