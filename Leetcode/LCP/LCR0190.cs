/*
 * Author: Deean
 * Date: 2023-12-26 22:26:15
 * FileName: LCR0190.cs
 * Description: LCR 190. 加密运算
 */

using System;
using System.Linq;

namespace LCP;

public class LCR0190 {
    public class Solution {
        public int EncryptionCalculate(int a, int b) {
            return new[] { a, b }.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.EncryptionCalculate(2, 3);
        Console.WriteLine(ans);
    }
}