/*
 * Author: Deean
 * Date: 2023-06-06 22:47:10
 * FileName: P1828.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P1828 {
    public class Solution {
        private int distance2(int a, int b, int x, int y) {
            return Math.Abs(a - x) * Math.Abs(a - x) + Math.Abs(b - y) * Math.Abs(b - y);
        }

        public int[] CountPoints(int[][] points, int[][] queries) {
            IList<int> count = new List<int>();
            foreach (var query in queries) {
                int a = query[0], b = query[1], r = query[2], cnt = 0;
                foreach (var point in points) {
                    int x = point[0], y = point[1];
                    if (distance2(a, b, x, y) <= r * r) {
                        cnt++;
                    }
                }
                count.Add(cnt);
            }
            return count.ToArray();
        }
    }

    public static void Test() {
        var points = Arrays.To2DArray("[[1,3],[3,3],[5,3],[2,2]]");
        var queries = Arrays.To2DArray("[[2,3,1],[4,3,1],[1,1,2]]");
        var s = new Solution();
        var ans = s.CountPoints(points, queries);
        Console.WriteLine(Arrays.ToString(ans));
    }
}