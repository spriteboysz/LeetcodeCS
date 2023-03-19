/*
 * Author: Deean
 * Date: 2023-03-19 09:54:55
 * FileName: P2341.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2341 {
    public class Solution {
        public int[] NumberOfPairs(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
            }
            int pair = 0, single = 0;
            foreach (var cnt in dict.Values) {
                pair += cnt / 2;
                single += cnt % 2;
            }
            return new[] { pair, single };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfPairs(new[] { 1, 3, 2, 1, 3, 2, 2 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}