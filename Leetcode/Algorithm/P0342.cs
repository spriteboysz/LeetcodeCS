/*
 * Author: Deean
 * Date: 2023-04-06 23:10:33
 * FileName: P0342.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0342 {
    public class Solution {
        public bool IsPowerOfFour(int n) {
            return n > 0 && (n & (n - 1)) == 0 && n % 3 == 1;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPowerOfFour(16);
        Console.WriteLine(ans);
    }
}