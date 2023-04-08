/*
 * Author: Deean
 * Date: 2023-04-08 10:29:32
 * FileName: P0088.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0088 {
    public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            for (int i = m; i < m + n; i++) {
                nums1[i] = nums2[i - m];
            }
            Array.Sort(nums1);
            Console.WriteLine(lib.Arrays.ToString(nums1));
        }
    }

    public static void Test() {
        var s = new Solution();
        s.Merge(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3);
    }
}