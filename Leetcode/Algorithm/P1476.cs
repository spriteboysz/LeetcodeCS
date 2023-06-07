/*
 * Author: Deean
 * Date: 2023-06-06 23:37:55
 * FileName: P1476.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1476 {
    public class SubrectangleQueries {
        private int[][] rectangle;

        public SubrectangleQueries(int[][] rectangle) {
            this.rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
            for (int i = row1; i <= row2; i++) {
                for (int j = col1; j <= col2; j++) {
                    rectangle[i][j] = newValue;
                }
            }
        }

        public int GetValue(int row, int col) {
            return rectangle[row][col];
        }
    }

    public static void Test() {
        var rectangle = Arrays.To2DArray("[[1,2,1],[4,3,4],[3,2,1],[1,1,1]]");
        SubrectangleQueries obj = new SubrectangleQueries(rectangle);
        Console.WriteLine(obj.GetValue(0, 2));
        obj.UpdateSubrectangle(0, 0, 3, 2, 5);
        Console.WriteLine(obj.GetValue(0, 2));
        Console.WriteLine(obj.GetValue(3, 1));
        obj.UpdateSubrectangle(3, 0, 3, 2, 10);
        Console.WriteLine(obj.GetValue(0, 2));
        Console.WriteLine(obj.GetValue(3, 1));
    }
}