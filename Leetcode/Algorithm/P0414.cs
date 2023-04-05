/*
 * Author: Deean
 * Date: 2023-04-05 19:58:29
 * FileName: P0414.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0414 {
    public class Solution {
        public int ThirdMax(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums) {
                set.Add(num);
            }
            List<int> list = set.ToList();
            list.Sort();
            list.Reverse();
            return list.Count < 3 ? list.Max() : list[2];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ThirdMax(new[] { 2, 2, 3, 1 });
        Console.WriteLine(ans);
    }
}