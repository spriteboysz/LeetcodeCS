/*
 * Author: Deean
 * Date: 2023-06-10 23:10:01
 * FileName: P1551.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1551 {
    public class Solution {
        public int MinOperations(int n) {
            return n * n / 4;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinOperations(6);
        Console.WriteLine(ans);
    }
}