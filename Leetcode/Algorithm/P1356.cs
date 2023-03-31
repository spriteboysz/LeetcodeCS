/*
 * Author: Deean
 * Date: 2023-03-30 23:25:22
 * FileName: P1356.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1356 {
    public class Solution {
        public int[] SortByBits(int[] arr) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in arr) {
                if (!dict.ContainsKey(num)) {
                    string ss = Convert.ToString(num, 2);
                    int value = ss.Count(c => c == '1');
                    dict.Add(num, value);
                }
            }
            Array.Sort(arr, (a, b) =>
                dict[a] == dict[b] ? a - b : dict[a] - dict[b]);
            return arr;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortByBits(new[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}