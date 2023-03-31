/*
 * Author: Deean
 * Date: 2023-03-30 22:46:28
 * FileName: P1374.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1374 {
    public class Solution {
        public string GenerateTheString(int n) {
            return n % 2 == 1 ? new string('a', n) : new string('a', n - 1) + "b";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GenerateTheString(4);
        Console.WriteLine(ans);
    }
}