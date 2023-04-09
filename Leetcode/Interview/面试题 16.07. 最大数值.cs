/*
 * Author: Deean
 * Date: 2023-04-09 09:52:55
 * FileName: 面试题 16.07. 最大数值.cs
 * Description:
*/

using System;
using System.Linq;

namespace Interview;

public class 面试题_16_07__最大数值 {
    public class Solution {
        public int Maximum(int a, int b) {
            return new[] { a, b }.Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Maximum(1, 2);
        Console.WriteLine(ans);
    }
}