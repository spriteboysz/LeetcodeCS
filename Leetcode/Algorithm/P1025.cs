/*
 * Author: Deean
 * Date: 2023-04-01 23:52:34
 * FileName: P1025.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1025 {
    public class Solution {
        public bool DivisorGame(int n) {
            return n % 2 == 0;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DivisorGame(3);
        Console.WriteLine(ans);
    }
}