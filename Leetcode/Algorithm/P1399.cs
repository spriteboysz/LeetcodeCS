/*
 * Author: Deean
 * Date: 2023-03-29 23:29:25
 * FileName: P1399.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1399 {
    public class Solution {
        public int CountLargestGroup(int n) {
            int[] hash = new int[55];
            for (int i = 1; i <= n; i++) {
                int sum = 0, m = i;
                while (m > 0) {
                    sum += m % 10;
                    m /= 10;
                }
                hash[sum]++;
            }

            int maximum = hash.Max();
            return hash.Count(item => item == maximum);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountLargestGroup(13);
        Console.WriteLine(ans);
    }
}