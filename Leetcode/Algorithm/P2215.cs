/*
 * Author: Deean
 * Date: 2023-03-19 14:06:28
 * FileName: P2215.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2215 {
    public class Solution {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
            int[] hash = new int[2001];
            foreach (var num in nums1) {
                hash[num + 1000] |= 1;
            }
            foreach (var num in nums2) {
                hash[num + 1000] |= 2;
            }
            IList<int> list1 = new List<int>(), list2 = new List<int>();
            for (int i = 0; i < 2001; i++) {
                if (hash[i] == 1) list1.Add(i - 1000);
                if (hash[i] == 2) list2.Add(i - 1000);
            }
            IList<IList<int>> diff = new List<IList<int>>();
            diff.Add(list1);
            diff.Add(list2);
            return diff;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindDifference(new[] { 1, 2, 3, 3 }, new[] { 1, 1, 2, 2 });
        Console.WriteLine(ans);
    }
}