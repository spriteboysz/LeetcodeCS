/*
 * Author: Deean
 * Date: 2023-03-26 14:14:01
 * FileName: P1725.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1725 {
    public class Solution {
        public int CountGoodRectangles(int[][] rectangles) {
            int n = rectangles.Length;
            int[] sides = new int[n];
            for (int i = 0; i < n; i++) {
                sides[i] = rectangles[i].Min();
            }
            int maximum = sides.Max();
            return sides.Count(side => side == maximum);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountGoodRectangles(lib.Arrays.To2DArray("[[5,8],[3,9],[5,12],[16,5]]"));
        Console.WriteLine(ans);
    }
}