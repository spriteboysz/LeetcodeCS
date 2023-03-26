/*
 * Author: Deean
 * Date: 2023-03-26 14:02:57
 * FileName: P1710.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1710 {
    public class Solution {
        public int MaximumUnits(int[][] boxTypes, int truckSize) {
            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
            int cnt = 0;
            foreach (var boxType in boxTypes) {
                int numberOfBoxes = boxType[0], numberOfUnitsPerBox = boxType[1];
                if (numberOfBoxes < truckSize) {
                    cnt += numberOfBoxes * numberOfUnitsPerBox;
                    truckSize -= numberOfBoxes;
                } else {
                    cnt += truckSize * numberOfUnitsPerBox;
                    break;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumUnits(lib.Arrays.To2DArray("[[1,3],[2,2],[3,1]]"), 4);
        Console.WriteLine(ans);
    }
}