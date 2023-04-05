/*
 * Author: Deean
 * Date: 2023-04-04 22:07:25
 * FileName: P0496.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0496 {
    public class Solution {
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = nums1.Length, m = nums2.Length;
            for (int i = 0; i < m; i++) {
                dict.Add(nums2[i], i);
            }

            int[] greater = new int[n];
            for (int i = 0; i < n; i++) {
                int start = dict[nums1[i]];
                greater[i] = -1;
                for (int j = start + 1; j < m; j++) {
                    if (nums2[j] > nums1[i]) {
                        greater[i] = nums2[j];
                        break;
                    }
                }
            }
            return greater;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NextGreaterElement(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}