/*
 * Author: Deean
 * Date: 2023-04-04 13:35:30
 * FileName: P0661.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0661 {
    public class Solution {
        public int[][] ImageSmoother(int[][] img) {
            int m = img.Length, n = img[0].Length;
            int[][] smoother = new int[m][];
            for (int i = 0; i < m; i++) {
                smoother[i] = new int[n];
            }
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    int num = 0, sum = 0;
                    for (int x = i - 1; x <= i + 1; x++) {
                        for (int y = j - 1; y <= j + 1; y++) {
                            if (x >= 0 && x < m && y >= 0 && y < n) {
                                num++;
                                sum += img[x][y];
                            }
                        }
                    }
                    smoother[i][j] = sum / num;
                }
            }
            return smoother;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ImageSmoother(lib.Arrays.To2DArray("[[100,200,100],[200,50,200],[100,200,100]]"));
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}