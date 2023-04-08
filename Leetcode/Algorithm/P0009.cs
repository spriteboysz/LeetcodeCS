/*
 * Author: Deean
 * Date: 2023-04-08 12:14:39
 * FileName: P0009.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0009 {
    public class Solution {
        public bool IsPalindrome(int x) {
            int num1 = x, num2 = 0;
            while (x > 0) {
                num2 = num2 * 10 + x % 10;
                x /= 10;
            }
            return num1 == num2;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPalindrome(121);
        Console.WriteLine(ans);
    }
}