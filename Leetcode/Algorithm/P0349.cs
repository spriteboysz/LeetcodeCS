/*
 * Author: Deean
 * Date: 2023-04-05 23:22:00
 * FileName: P0349.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0349 {
    public class Solution {
        public int[] Intersection(int[] nums1, int[] nums2) {
            HashSet<int> set1 = new HashSet<int>();
            foreach (var num in nums1) {
                set1.Add(num);
            }
            
            HashSet<int> set2 = new HashSet<int>();
            foreach (var num in nums2) {
                set2.Add(num);
            }

            IList<int> list = new List<int>();
            foreach (var num in set1) {
                if (set2.Contains(num)) {
                    list.Add(num);
                }
            }
            return list.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Intersection(new[] { 1, 2, 2, 1 }, new[] { 2, 2 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}