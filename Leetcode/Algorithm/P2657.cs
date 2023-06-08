/*
 * Author: Deean
 * Date: 2023-06-07 23:15:41
 * FileName: P2657.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P2657 {
    public class Solution {
        public int[] FindThePrefixCommonArray(int[] nums1, int[] nums2) {
            IList<int> common = new List<int>();
            for (int i = 0, n = nums1.Length; i < n; i++) {
                IDictionary<int, int> dict = new Dictionary<int, int>();
                for (int j = 0; j <= i; j++) {
                    if (!dict.ContainsKey(nums1[j])) {
                        dict[nums1[j]] = 0;
                    }
                    dict[nums1[j]] += 1;
                    if (!dict.ContainsKey(nums2[j])) {
                        dict[nums2[j]] = 0;
                    }
                    dict[nums2[j]] += 1;
                }
                common.Add(dict.Values.Count(v => v == 2));
            }
            return common.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindThePrefixCommonArray(new[] { 1, 2, 3, 4 }, new[] { 3, 1, 2, 4 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}