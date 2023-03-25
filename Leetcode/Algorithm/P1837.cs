/*
 * Author: Deean
 * Date: 2023-03-25 21:31:41
 * FileName: P1837.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1837 {
    public class Solution {
        public int SumBase(int n, int k) {
            int sum = 0;
            while (n > 0) {
                sum += n % k;
                n /= k;
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumBase(34, 6);
        Console.WriteLine(ans);
    }
}