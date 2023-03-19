/*
 * Author: Deean
 * Date: 2023-03-19 09:40:10
 * FileName: P2351.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P2351 {
    public class Solution {
        public char RepeatedCharacter(string s) {
            HashSet<char> set = new HashSet<char>();
            foreach (var c in s) {
                if (set.Contains(c)) return c;
                set.Add(c);
            }
            return '\0';
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RepeatedCharacter("abccbaacz");
        Console.WriteLine(ans);
    }
}