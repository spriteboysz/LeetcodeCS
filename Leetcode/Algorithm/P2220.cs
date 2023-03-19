/*
 * Author: Deean
 * Date: 2023-03-19 14:02:41
 * FileName: P2220.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2220 {
    public class Solution {
        public int MinBitFlips(int start, int goal) {
            int xor = start ^ goal;
            int cnt = 0;
            while (xor > 0) {
                cnt += xor & 1;
                xor >>= 1;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinBitFlips(10, 7);
        Console.WriteLine(ans);
    }
}