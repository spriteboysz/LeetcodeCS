/*
 * Author: Deean
 * Date: 2023-03-19 13:32:22
 * FileName: P2235.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2235 {
    public class Solution {
        public int Sum(int num1, int num2) {
            return num1 + num2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Sum(1, 2);
        Console.WriteLine(ans);
    }
}