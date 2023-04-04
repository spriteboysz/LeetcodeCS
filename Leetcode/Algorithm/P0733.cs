/*
 * Author: Deean
 * Date: 2023-04-04 12:18:49
 * FileName: P0733.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0733 {
    public class Solution {
        private int origin;

        private void DFS(int[][] image, int sr, int sc, int color) {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != origin) {
                return;
            }
            image[sr][sc] = color;
            DFS(image, sr + 1, sc, color);
            DFS(image, sr - 1, sc, color);
            DFS(image, sr, sc + 1, color);
            DFS(image, sr, sc - 1, color);
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
            origin = image[sr][sc];
            if (origin != color) {
                DFS(image, sr, sc, color);
            }
            return image;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FloodFill(lib.Arrays.To2DArray("[[1,1,1],[1,1,0],[1,0,1]]"), 1, 1, 2);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}