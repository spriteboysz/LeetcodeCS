/*
 * Author: Deean
 * Date: 2023-04-04 15:04:21
 * FileName: P0709.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0709 {
    public class Solution {
        public string ToLowerCase(string s) {
            return s.ToLower();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ToLowerCase("Hello");
        Console.WriteLine(ans);
    }
}