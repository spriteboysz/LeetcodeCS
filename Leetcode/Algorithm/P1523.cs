/*
 * Author: Deean
 * Date: 2023-03-27 23:32:29
 * FileName: P1523.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1523 {
    public class Solution {
        public int CountOdds(int low, int high) {
            return ((high + 1) >> 1) - (low >> 1) ;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountOdds(3, 7);
        Console.WriteLine(ans);
    }
}