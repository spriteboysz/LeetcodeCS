/*
 * Author: Deean
 * Date: 2023-03-25 21:46:42
 * FileName: P1854.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1854 {
    public class Solution {
        public int MaximumPopulation(int[][] logs) {
            int[] years = new int[101];
            foreach (var log in logs) {
                for (int i = log[0] - 1950; i < log[1] - 1950; i++) {
                    years[i]++;
                }
            }
            int max = years.Max(), maximum = 0;
            for (int i = 0; i < 101; i++) {
                if (years[i] == max) {
                    maximum = i;
                    break;
                }
            }
            return maximum + 1950;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumPopulation(lib.Arrays.To2DArray("[[1950,1961],[1960,1971],[1970,1981]]"));
        Console.WriteLine(ans);
    }
}