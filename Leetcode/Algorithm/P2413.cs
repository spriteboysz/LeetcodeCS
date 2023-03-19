/*
 * Author: Deean
 * Date: 2023-03-18 23:05:09
 * FileName: P2413.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2413 {
    public class Solution {
        public int SmallestEvenMultiple(int n) {
            return n % 2 == 0 ? n : n * 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SmallestEvenMultiple(3);
        Console.WriteLine(ans);
    }
}