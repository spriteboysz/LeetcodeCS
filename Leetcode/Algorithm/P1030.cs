/*
 * Author: Deean
 * Date: 2023-04-01 23:23:58
 * FileName: P1030.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1030 {
    public class Solution {
        public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter) {
            List<int> distance = new List<int>();
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    int dis = Math.Abs(i - rCenter) + Math.Abs(j - cCenter);
                    dis = dis * 10000 + i * 100 + j;
                    distance.Add(dis);
                }
            }
            distance.Sort();
            List<int[]> order = new List<int[]>();
            foreach (var num in distance) {
                int x = (num / 100) % 100, y = num % 100;
                order.Add(new[] { x, y });
            }
            return order.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AllCellsDistOrder(2, 2, 0, 1);
        Console.WriteLine(ans);
    }
}