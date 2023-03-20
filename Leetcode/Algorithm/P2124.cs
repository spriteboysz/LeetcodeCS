/*
 * Author: Deean
 * Date: 2023-03-20 23:27:35
 * FileName: P2124.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P2124 {
    public class Solution {
        public bool CheckString(string s) {
            return !s.Contains("ba");
        }  
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckString("aaabbb");
        Console.WriteLine(ans);
    }
}