/*
 * Author: Deean
 * Date: 2023-03-31 21:23:42
 * FileName: P1317.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1317 {
    public class Solution {
        private bool Check(int n) {
            while (n > 0) {
                if (n % 10 == 0) {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        public int[] GetNoZeroIntegers(int n) {
            for (int i = 1; i < n; i++) {
                if (Check(i) && Check(n - i)) {
                    return new[] { i, n - i };
                }
            }
            return new[] { -1, -1 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetNoZeroIntegers(1000);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}