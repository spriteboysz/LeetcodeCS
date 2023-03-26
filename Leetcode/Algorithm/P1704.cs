/*
 * Author: Deean
 * Date: 2023-03-26 13:58:34
 * FileName: P1704.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1704 {
    public class Solution {
        private int Process(string s) {
            string vowels = "AEIOUaeiou";
            return s.Count(c => vowels.Contains(c.ToString()));
        }

        public bool HalvesAreAlike(string s) {
            int n = s.Length;
            return Process(s.Substring(0, n / 2)) == Process(s.Substring(n / 2));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HalvesAreAlike("book");
        Console.WriteLine(ans);
    }
}