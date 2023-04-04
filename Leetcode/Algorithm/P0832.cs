/*
 * Author: Deean
 * Date: 2023-04-04 09:35:20
 * FileName: P0832.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0832 {
    public class Solution {
        public int[][] FlipAndInvertImage(int[][] image) {
            int m = image[0].Length;
            foreach (var row in image) {
                for (int i = 0; i < m/2; i++) {
                    int temp = row[i];
                    row[i] = row[m - 1 - i];
                    row[m - 1 - i] = temp;
                }
                for (int i = 0; i < m; i++) {
                    row[i] = 1 - row[i];
                }
            }
            return image;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FlipAndInvertImage(lib.Arrays.To2DArray("[[1,1,0],[1,0,1],[0,0,0]]"));
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}