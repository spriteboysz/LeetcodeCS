/*
 * Author: Deean
 * Date: 2023-03-19 22:29:30
 * FileName: P2078.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2078 {
    public class Solution {
        public int MaxDistance(int[] colors) {
            int distance1 = -1, distance2 = -1, n = colors.Length;
            for (int i = n - 1; i >= 0; i--) {
                if (colors[i] != colors[0]) {
                    distance1 = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++) {
                if (colors[i] != colors[n - 1]) {
                    distance2 = n - 1 - i;
                    break;
                }
            }
            return Math.Max(distance1, distance2);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDistance(new[] { 1, 8, 3, 8, 3 });
        Console.WriteLine(ans);
    }
}