/*
 * Author: Deean
 * Date: 2023-03-21 23:38:07
 * FileName: P2185.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2185 {
    public class Solution {
        public int PrefixCount(string[] words, string pref) {
            return words.Count(word => word.StartsWith(pref));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PrefixCount(new[] { "pay", "attention", "practice", "attend" }, "at");
        Console.WriteLine(ans);
    }
}