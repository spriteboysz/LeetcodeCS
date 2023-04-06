/*
 * Author: Deean
 * Date: 2023-04-06 23:27:27
 * FileName: P0292.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0292 {
    public class Solution {
        public bool CanWinNim(int n) {
            return n % 4 != 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanWinNim(4);
        Console.WriteLine(ans);
    }
}