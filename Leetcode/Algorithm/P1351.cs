/*
 * Author: Deean
 * Date: 2023-03-30 23:36:43
 * FileName: P1351.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P1351 {
    public class Solution {
        public int CountNegatives(int[][] grid) {
            return grid.Sum(row => row.Count(num => num < 0));
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountNegatives(lib.Arrays.To2DArray("[[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]"));
        Console.WriteLine(ans);
    }
}