/*
 * Author: Deean
 * Date: 2023-04-09 11:25:16
 * FileName: 面试题 05.01. 插入.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_05_01__插入 {
    public class Solution {
        public int InsertBits(int N, int M, int i, int j) {
            int bits = ((int)Math.Pow(2, i) - 1) & N;
            N >>= j + 1;
            N <<= j - i + 1;
            N |= M;
            N <<= i;
            N |= bits;
            return N;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InsertBits(1024, 19, 2, 6);
        Console.WriteLine(ans);
    }
}