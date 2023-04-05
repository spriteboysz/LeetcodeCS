/*
 * Author: Deean
 * Date: 2023-04-05 16:33:20
 * FileName: P0551.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P0551 {
    public class Solution {
        public bool CheckRecord(string s) {
            return s.Count(c => c == 'A') < 2 && !s.Contains("LLL");
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckRecord("PPALLP");
        Console.WriteLine(ans);
    }
}