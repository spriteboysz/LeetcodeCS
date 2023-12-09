/*
 * Author: Deean
 * Date: 2023-12-08 21:18:41
 * FileName: LCR0166.cs
 * Description: LCR 166. 珠宝的最高价值
 */

using System;

namespace LCP;

public class LCR0166 {
    public class Solution {
        public int JewelleryValue(int[][] frame) {
            for (int i = 0; i < frame.Length; i++) {
                for (int j = 0; j < frame[0].Length; j++) {
                    if (i == 0 && j == 0) {
                        continue;
                    }
                    if (i == 0) {
                        frame[i][j] += frame[i][j - 1];
                    } else if (j == 0) {
                        frame[i][j] += frame[i - 1][j];
                    } else {
                        frame[i][j] += Math.Max(frame[i - 1][j], frame[i][j - 1]);
                    }
                }
            }
            return frame[frame.Length - 1][frame[0].Length - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.JewelleryValue(lib.Arrays.To2DArray("[[1,3,1],[1,5,1],[4,2,1]]"));
        Console.WriteLine(ans);
    }
}