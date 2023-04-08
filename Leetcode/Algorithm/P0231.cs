/*
 * Author: Deean
 * Date: 2023-04-07 20:51:00
 * FileName: P0231.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0231 {
    public class Solution {
        public bool IsPowerOfTwo(int n) {
            while (n > 0 && n % 2 == 0) {
                n /= 2;
            }
            return n == 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPowerOfTwo(4);
        Console.WriteLine(ans);
    }
}