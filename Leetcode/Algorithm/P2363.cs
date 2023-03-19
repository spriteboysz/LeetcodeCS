/*
 * Author: Deean
 * Date: 2023-03-19 09:02:44
 * FileName: P2363.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2363 {
    public class Solution {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in items1) {
                if (dict.ContainsKey(item[0])) {
                    dict[item[0]] += item[1];
                } else {
                    dict.Add(item[0], item[1]);
                }
            }
            foreach (var item in items2) {
                if (dict.ContainsKey(item[0])) {
                    dict[item[0]] += item[1];
                } else {
                    dict.Add(item[0], item[1]);
                }
            }
            IList<IList<int>> res = new List<IList<int>>();
            foreach (var kv in dict) {
                res.Add(new List<int> { kv.Key, kv.Value });
            }
            ((List<IList<int>>) res).Sort((a, b) => a[0] - b[0]);
            return res;
        }
    }

    public static void Test() {
        var s = new Solution();
        int[][] items1 = new int[3][];
        items1[0] = new[] { 1, 1 };
        items1[1] = new[] { 4, 5 };
        items1[2] = new[] { 3, 8 };
        int[][] items2 = new int[2][];
        items2[0] = new[] { 3, 1 };
        items2[1] = new[] { 1, 5 };
        var ans = s.MergeSimilarItems(items1, items2);
        Console.WriteLine(ans);
    }
}