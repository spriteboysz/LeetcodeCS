/*
 * Author: Deean
 * Date: 2023-04-08 17:07:11
 * FileName: 剑指 Offer II 003. 前 n 个数字二进制中 1 的个数.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_II_003__前_n_个数字二进制中_1_的个数 {
    public class Solution {
        public int[] CountBits(int n) {
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++) {
                int num = i, sum = 0;
                while (num > 0) {
                    sum += num & 1;
                    num >>= 1;
                }
                bits[i] = sum;
            }
            return bits;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountBits(5);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}