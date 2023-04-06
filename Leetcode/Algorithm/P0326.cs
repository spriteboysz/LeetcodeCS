/*
 * Author: Deean
 * Date: 2023-04-06 23:18:37
 * FileName: P0326.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0326 {
    public class Solution {
        public bool IsPowerOfThree(int n) {
            while (n > 0 && n % 3 == 0) {
                n /= 3;
            }
            return n == 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPowerOfThree(27);
        Console.WriteLine(ans);
    }
}