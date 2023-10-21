/*
 * Author: Deean
 * Date: 2023-10-20 22:41:20
 * FileName: LCR0003.cs
 * Description: LCR 003. 比特位计数
 */

using System;
using lib;

namespace LCP;

public class LCR0003 {
    public class Solution {
        public int[] CountBits(int n) {
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++) {
                int num = i;
                while (num > 0) {
                    num &= num - 1;
                    bits[i]++;
                }
            }
            return bits;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountBits(5);
        Console.WriteLine(Arrays.ToString(ans));
    }
}