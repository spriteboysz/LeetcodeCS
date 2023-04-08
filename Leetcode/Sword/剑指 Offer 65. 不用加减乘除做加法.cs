/*
 * Author: Deean
 * Date: 2023-04-08 16:54:39
 * FileName: 剑指 Offer 65. 不用加减乘除做加法.cs
 * Description:
*/

using System;
using System.Linq;

namespace Sword;

public class 剑指_Offer_65__不用加减乘除做加法 {
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