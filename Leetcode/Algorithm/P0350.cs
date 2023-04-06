/*
 * Author: Deean
 * Date: 2023-04-05 23:28:04
 * FileName: P0350.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0350 {
    public class Solution {
        public int[] Intersect(int[] nums1, int[] nums2) {
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            foreach (var num in nums1) {
                if (!dict1.ContainsKey(num)) {
                    dict1.Add(num, 0);
                }
                dict1[num]++;
            }
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            foreach (var num in nums2) {
                if (!dict2.ContainsKey(num)) {
                    dict2.Add(num, 0);
                }
                dict2[num]++;
            }
            IList<int> list = new List<int>();
            foreach (var k in dict1.Keys) {
                if (dict2.ContainsKey(k)) {
                    for (int i = 0; i < Math.Min(dict1[k], dict2[k]); i++) {
                        list.Add(k);
                    }
                }
            }
            return list.ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Intersect(new[]{1,2,2,1}, new[]{2,2});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}