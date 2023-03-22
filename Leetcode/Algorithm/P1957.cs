/*
 * Author: Deean
 * Date: 2023-03-22 23:48:14
 * FileName: P1957.cs
 * Description:
*/

using System;
using System.Linq;
using System.Text;

namespace Algorithm;

public class P1957 {
    public class Solution {
        public string MakeFancyString(string s) {
            StringBuilder ss = new StringBuilder();
            foreach (var c in s.Where(c =>
                         ss.Length < 2 || ss[ss.Length - 2] != ss[ss.Length - 1] || ss[ss.Length - 2] != c)) {
                ss.Append(c);
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MakeFancyString("aaabaaaa");
        Console.WriteLine(ans);
    }
}