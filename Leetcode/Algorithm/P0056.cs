﻿/*
 * Author: Deean
 * Date: 2023-05-28 11:15:00
 * FileName: P0056.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0056 {
    public class Solution {
        public int[][] Merge(int[][] intervals) {
            Array.Sort(intervals, (a, b) => {
                if (a[0] != b[0]) {
                    return a[0] - b[0];
                }
                return b[1] - a[1];
            });
            IList<int[]> merged = new List<int[]>();
            merged.Add(intervals[0]);
            for (int i = 1, n = intervals.Length; i < n; i++) {
                int[] cur = intervals[i];
                int[] prev = merged[merged.Count - 1];
                if (cur[0] == prev[0]) continue;
                if (cur[0] < prev[1]) {
                    prev[1] = Math.Max(cur[1], prev[1]);
                } else {
                    merged.Add(intervals[i]);
                }
            }
            return merged.ToArray();
        }
    }

    public static void Test() {
        var intervals = Arrays.To2DArray("[[1,3],[2,6],[8,10],[15,18]]");
        var s = new Solution();
        var ans = s.Merge(intervals);
        Console.WriteLine(ans);
    }
}