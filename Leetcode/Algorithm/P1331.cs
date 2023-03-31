/*
 * Author: Deean
 * Date: 2023-03-31 20:58:35
 * FileName: P1331.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1331 {
    public class Solution {
        public int[] ArrayRankTransform(int[] arr) {
            int n = arr.Length;
            int[] sorted = new int[n];
            for (int i = 0; i < n; i++) {
                sorted[i] = arr[i];
            }
            Array.Sort(sorted);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0, j = 0; i < n; i++) {
                if (!dict.ContainsKey(sorted[i])) {
                    dict.Add(sorted[i], ++j);
                }
            }
            for (int i = 0; i < n; i++) {
                sorted[i] = dict[arr[i]];
            }
            return sorted;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ArrayRankTransform(new[] { 40, 10, 20, 30 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}