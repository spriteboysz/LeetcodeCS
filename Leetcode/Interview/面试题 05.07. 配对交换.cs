/*
 * Author: Deean
 * Date: 2023-04-09 11:39:17
 * FileName: 面试题 05.07. 配对交换.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_05_07__配对交换 {
    public class Solution {
        public int ExchangeBits(int num) {
            var maskOdd = 0xaaaaaaaa;
            var maskEven = 0x55555555;
            var odd = num & maskOdd;
            var even = num & maskEven;
            return (int)((odd >> 1) + (even << 1));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ExchangeBits(2);
        Console.WriteLine(ans);
    }
}