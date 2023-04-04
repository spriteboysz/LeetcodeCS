/*
 * Author: Deean
 * Date: 2023-04-04 09:32:19
 * FileName: P0836.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0836 {
    public class Solution {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
            return rec2[0] < rec1[2] && rec2[1] < rec1[3] && rec1[0] < rec2[2] && rec1[1] < rec2[3];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsRectangleOverlap(new[] { 0, 0, 2, 2 }, new[] { 1, 1, 3, 3 });
        Console.WriteLine(ans);
    }
}