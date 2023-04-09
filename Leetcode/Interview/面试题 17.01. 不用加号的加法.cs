/*
 * Author: Deean
 * Date: 2023-04-08 22:21:29
 * FileName: 面试题 17.01. 不用加号的加法.cs
 * Description:
*/

using System;
using System.Linq;

namespace Interview;

public class 面试题_17_01__不用加号的加法 {
    public class Solution {
        public int Add(int a, int b) {
            return new[] { a, b }.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Add(1, 1);
        Console.WriteLine(ans);
    }
}