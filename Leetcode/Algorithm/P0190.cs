/*
 * Author: Deean
 * Date: 2023-04-07 23:32:45
 * FileName: P0190.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0190 {
    public class Solution {
        public uint reverseBits(uint n) {
            const int BITS = 32;
            uint reversed = 0;
            for (int i = 0; i < BITS; i++) {
                uint bit = (n >> i) & 1;
                reversed |= bit << (BITS - 1 - i);
            }
            return reversed;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.reverseBits(43261596);
        Console.WriteLine(ans);
    }
}