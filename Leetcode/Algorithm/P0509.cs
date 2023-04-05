/*
 * Author: Deean
 * Date: 2023-04-05 15:56:45
 * FileName: P0509.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0509 {
    public class Solution {
        public int Fib(int n) {
            if (n <= 1) return n;
            int a = 0, b = 1;
            while (n-- > 2) {
                int c = a + b;
                a = b;
                b = c;
            }
            return a + b;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Fib(30);
        Console.WriteLine(ans);
    }
}