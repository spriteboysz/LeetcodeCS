/*
 * Author: Deean
 * Date: 2023-03-26 13:54:40
 * FileName: P1688.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1688 {
    public class Solution {
        public int NumberOfMatches(int n) {
            int cnt = 0;
            while (n > 1) {
                if (n % 2 == 0) {
                    cnt += n / 2;
                    n /= 2;
                } else {
                    cnt += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfMatches(14);
        Console.WriteLine(ans);
    }
}