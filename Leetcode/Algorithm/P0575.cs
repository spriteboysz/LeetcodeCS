/*
 * Author: Deean
 * Date: 2023-04-05 17:19:32
 * FileName: P0575.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0575 {
    public class Solution {
        public int DistributeCandies(int[] candyType) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var type in candyType) {
                if (!dict.ContainsKey(type)) {
                    dict.Add(type, 0);
                }
                dict[type]++;
            }
            return Math.Min(dict.Count, candyType.Length / 2);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistributeCandies(new[] { 1, 1, 2, 2, 3, 3 });
        Console.WriteLine(ans);
    }
}