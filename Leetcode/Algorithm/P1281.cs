/*
 * Author: Deean
 * Date: 2023-03-31 22:44:17
 * FileName: P1281.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1281 {
    public class Solution {
        public int SubtractProductAndSum(int n) {
            int sum = 0, product = 1;
            while (n > 0) {
                int cur = n % 10;
                sum += cur;
                product *= cur;
                n /= 10;
            }
            return product - sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SubtractProductAndSum(4421);
        Console.WriteLine(ans);
    }
}