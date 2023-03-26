/*
 * Author: Deean
 * Date: 2023-03-26 13:47:15
 * FileName: P1678.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1678 {
    public class Solution {
        public string Interpret(string command) {
            return command.Replace("()", "o").Replace("(al)", "al");
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Interpret("(al)G(al)()()G");
        Console.WriteLine(ans);
    }
}