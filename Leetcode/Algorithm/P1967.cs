/*
 * Author: Deean
 * Date: 2023-03-22 23:28:25
 * FileName: P1967.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P1967 {
    public class Solution {
        public int NumOfStrings(string[] patterns, string word) {
            return patterns.Count(word.Contains);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumOfStrings(new []{"a","abc","bc","d"}, "abc");
        Console.WriteLine(ans);
    }
}