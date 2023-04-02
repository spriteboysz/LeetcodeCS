/*
 * Author: Deean
 * Date: 2023-04-01 22:59:14
 * FileName: P1051.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1051 {
    public class Solution {
        public int HeightChecker(int[] heights) {
            int n = heights.Length;
            int[] sorted = new int[n];
            for (int i = 0; i < n; i++) {
                sorted[i] = heights[i];
            }
            Array.Sort(sorted);
            int cnt = 0;
            for (int i = 0; i < n; i++) {
                if (heights[i] != sorted[i]) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HeightChecker(new[] { 1, 1, 4, 2, 1, 3 });
        Console.WriteLine(ans);
    }
}