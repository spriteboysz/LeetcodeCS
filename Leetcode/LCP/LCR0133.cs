/*
 * Author: Deean
 * Date: 2023-11-17 21:25:41
 * FileName: LCR0133.cs
 * Description: LCR 133. 位 1 的个数
 */

using System;

namespace LCP;

public class LCR0133 {
    public class Solution {
        public int HammingWeight(uint n) {
            int weight = 0;
            while (n > 0) {
                weight += (int)n & 1;
                n >>= 1;
            }
            return weight;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HammingWeight(11);
        Console.WriteLine(ans);
    }
}