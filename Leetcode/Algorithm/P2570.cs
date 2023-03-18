/*
 * Author: Deean
 * Date: 2023-03-18 12:09:35
 * FileName: P2570.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2570 {
    public class Solution {
        public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
            List<int[]> merge = new List<int[]>();
            int i = 0, j = 0;
            for (; i < nums1.Length && j < nums2.Length;) {
                if (nums1[i][0] < nums2[j][0]) {
                    merge.Add(nums1[i]);
                    i++;
                } else if (nums1[i][0] > nums2[j][0]) {
                    merge.Add(nums2[j]);
                    j++;
                } else {
                    merge.Add(new[] { nums1[i][0], nums1[i][1] + nums2[j][1] });
                    i++;
                    j++;
                }
            }

            for (; i < nums1.Length; i++) {
                merge.Add(nums1[i]);
            }

            for (; j < nums2.Length; j++) {
                merge.Add(nums2[j]);
            }

            return merge.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        int[][] nums1 = new int [3][];
        nums1[0] = new[] { 1, 2 };
        nums1[1] = new[] { 2, 3 };
        nums1[2] = new[] { 4, 5 };
        int[][] nums2 = new int [3][];
        nums2[0] = new[] { 1, 4 };
        nums2[1] = new[] { 3, 2 };
        nums2[2] = new[] { 4, 1 };
        var ans = s.MergeArrays(nums1, nums2);
        Console.WriteLine(ans);
    }
}