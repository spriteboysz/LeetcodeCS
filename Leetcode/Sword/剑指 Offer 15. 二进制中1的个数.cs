/*
 * Author: Deean
 * Date: 2023-04-08 13:26:39
 * FileName: 剑指 Offer 15. 二进制中1的个数.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_15__二进制中1的个数 {
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