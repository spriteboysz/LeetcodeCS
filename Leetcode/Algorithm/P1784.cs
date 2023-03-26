/*
 * Author: Deean
 * Date: 2023-03-25 22:42:32
 * FileName: P1784.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1784 {
    public class Solution {
        public bool CheckOnesSegment(string s) {
            return !s.Contains("01") || !s.Contains("10");
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckOnesSegment("1001");
        Console.WriteLine(ans);
    }
}