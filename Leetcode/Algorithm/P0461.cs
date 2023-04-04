/*
 * Author: Deean
 * Date: 2023-04-04 19:50:46
 * FileName: P0461.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0461 {
    public class Solution {
        public int HammingDistance(int x, int y) {
            int distance = 0;
            int xor = x ^ y;
            while (xor > 0) {
                distance += xor & 1;
                xor >>= 1;
            }
            return distance;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HammingDistance(1, 4);
        Console.WriteLine(ans);
    }
}