/*
 * Author: Deean
 * Date: 2023-05-31 22:32:56
 * FileName: 剑指 Offer II 100. 三角形中最小路径之和.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_100__三角形中最小路径之和 {
    public class Solution {
        public int MinimumTotal(IList<IList<int>> triangle) {
            for (int i = 1; i < triangle.Count; i++) {
                triangle[i][0] += triangle[i - 1][0];
                for (int j = 1; j < i; j++) {
                    triangle[i][j] += Math.Min(triangle[i - 1][j - 1], triangle[i - 1][j]);
                }
                triangle[i][i] += triangle[i - 1][i - 1];
            }
            return triangle.Last().Min();
        }
    }

    public static void Test() {
        IList<IList<int>> triangle = new List<IList<int>>();
        IList<int> row1 = new List<int> { 2 };
        IList<int> row2 = new List<int> { 3, 4 };
        IList<int> row3 = new List<int> { 6, 5, 7 };
        IList<int> row4 = new List<int> { 4, 1, 8, 3 };
        triangle.Add(row1);
        triangle.Add(row2);
        triangle.Add(row3);
        triangle.Add(row4);
        var s = new Solution();
        var ans = s.MinimumTotal(triangle);
        Console.WriteLine(ans);
    }
}