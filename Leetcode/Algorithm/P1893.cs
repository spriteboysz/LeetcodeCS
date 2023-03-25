/*
 * Author: Deean
 * Date: 2023-03-24 22:01:50
 * FileName: P1893.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1893 {
    public class Solution {
        public bool IsCovered(int[][] ranges, int left, int right) {
            int[] hash = new int[51];
            foreach (var range in ranges) {
                for (int i = range[0]; i <= range[1]; i++) {
                    hash[i]++;
                }
            }
            for (int i = left; i <= right; i++) {
                if (hash[i] == 0) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        int[][] ranges = new int[3][];
        ranges[0] = new[] { 1, 2 };
        ranges[1] = new[] { 3, 4 };
        ranges[2] = new[] { 5, 6 };
        var s = new Solution();
        var ans = s.IsCovered(ranges, 2, 5);
        Console.WriteLine(ans);
    }
}