/*
 * Author: Deean
 * Date: 2023-03-18 19:12:27
 * FileName: P2481.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2481 {
    public class Solution {
        public int NumberOfCuts(int n) {
            if (n == 1) return 0;
            return n % 2 == 0 ? n / 2 : n;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfCuts(4);
        Console.WriteLine(ans);
    }
}