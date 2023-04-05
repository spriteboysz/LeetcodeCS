/*
 * Author: Deean
 * Date: 2023-04-04 21:51:32
 * FileName: P0492.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0492 {
    public class Solution {
        public int[] ConstructRectangle(int area) {
            for (int i = (int) Math.Ceiling(Math.Sqrt(area)); i <= area; i++) {
                if (area % i == 0) {
                    return new[] { i, area / i };
                }
            }
            return new[] { -1, -1 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConstructRectangle(122122);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}