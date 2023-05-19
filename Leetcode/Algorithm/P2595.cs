/*
 * Author: Deean
 * Date: 2023-05-19 22:21:44
 * FileName: P2595.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2595 {
    public class Solution {
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public int[] EvenOddBit(int n) {
            int[] bits = { 0, 0 };
            for (int i = 0; n > 0; i ^= 1) {
                if ((n & 1) > 0) bits[i]++;
                n >>= 1;
            }
            return bits;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.EvenOddBit(17);
        Console.WriteLine(Arrays.ToString(ans));
    }
}