/*
 * Author: Deean
 * Date: 2023-03-26 22:24:19
 * FileName: P1742.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1742 {
    public class Solution {
        public int CountBalls(int lowLimit, int highLimit) {
            int[] hash = new int[55];
            for (int i = lowLimit; i <= highLimit; i++) {
                int sum = 0, num = i;
                while (num > 0) {
                    sum += num % 10;
                    num /= 10;
                }
                hash[sum]++;
            }
            return hash.Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountBalls(5, 15);
        Console.WriteLine(ans);
    }
}