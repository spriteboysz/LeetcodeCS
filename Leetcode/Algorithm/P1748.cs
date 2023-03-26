/*
 * Author: Deean
 * Date: 2023-03-26 22:29:29
 * FileName: P1748.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1748 {
    public class Solution {
        public int SumOfUnique(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
            }
            return dict.Where(pair => pair.Value == 1).Sum(pair => pair.Key);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumOfUnique(new[] { 1, 2, 3, 2 });
        Console.WriteLine(ans);
    }
}