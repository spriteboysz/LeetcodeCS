/*
 * Author: Deean
 * Date: 2023-04-06 23:14:44
 * FileName: P0338.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0338 {
    public class Solution {
        public int[] CountBits(int n) {
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++) {
                int cnt = 0, num = i;
                while (num > 0) {
                    cnt += num & 1;
                    num >>= 1;
                }
                bits[i] = cnt;
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