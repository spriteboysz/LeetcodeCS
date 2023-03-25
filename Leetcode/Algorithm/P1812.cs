/*
 * Author: Deean
 * Date: 2023-03-24 23:21:44
 * FileName: P1812.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1812 {
    public class Solution {
        public bool SquareIsWhite(string coordinates) {
            return (coordinates[0] + coordinates[1]) % 2 != 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SquareIsWhite("a1");
        Console.WriteLine(ans);
    }
}