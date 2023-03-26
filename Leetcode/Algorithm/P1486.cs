/*
 * Author: Deean
 * Date: 2023-03-26 23:56:30
 * FileName: P1486.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1486 {
    public class Solution {
        public int XorOperation(int n, int start) {
            int xor = 0;
            for (int i = 0; i < n; i++) {
                xor ^= start + i * 2;
            }
            return xor;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.XorOperation(5, 0);
        Console.WriteLine(ans);
    }
}