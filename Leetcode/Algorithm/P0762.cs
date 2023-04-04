/*
 * Author: Deean
 * Date: 2023-04-04 11:17:39
 * FileName: P0762.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P0762 {
    public class Solution {
        public int CountPrimeSetBits(int left, int right) {
            int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int cnt = 0;
            for (int i = left; i <= right; i++) {
                int bits = 0, num = i;
                while (num > 0) {
                    bits += num & 1;
                    num >>= 1;
                }
                if (prime.Contains(bits)) cnt++;
            }
            return cnt;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountPrimeSetBits(6, 10);
        Console.WriteLine(ans);
    }
}