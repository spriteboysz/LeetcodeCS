/*
 * Author: Deean
 * Date: 2023-03-18 22:33:40
 * FileName: P2427.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2427 {
    public class Solution {
        public int CommonFactors(int a, int b) {
            int cnt = 0;
            for (int i = 1; i <= Math.Min(a, b); i++) {
                if (a % i == 0 && b % i == 0) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CommonFactors(12, 6);
        Console.WriteLine(ans);
    }
}