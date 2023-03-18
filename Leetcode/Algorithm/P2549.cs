/*
 * Author: Deean
 * Date: 2023-03-18 16:36:36
 * FileName: P2549.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2549 {
    public class Solution {
        public int DistinctIntegers(int n) {
            return n == 1 ? 1 : n - 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistinctIntegers(5);
        Console.WriteLine(ans);
    }
}