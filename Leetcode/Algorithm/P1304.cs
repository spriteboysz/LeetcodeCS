/*
 * Author: Deean
 * Date: 2023-03-31 21:47:35
 * FileName: P1304.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1304 {
    public class Solution {
        public int[] SumZero(int n) {
            List<int> list = new List<int>();
            if (n % 2 == 1) {
                list.Add(0);
            }
            for (int i = 1; i <= n / 2; i++) {
                list.Add(i);
                list.Add(-i);
            }
            return list.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumZero(5);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}