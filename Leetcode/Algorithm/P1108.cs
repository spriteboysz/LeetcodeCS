/*
 * Author: Deean
 * Date: 2023-03-31 23:45:05
 * FileName: P1108.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1108 {
    public class Solution {
        public string DefangIPaddr(string address) {
            StringBuilder ss = new StringBuilder();
            foreach (var c in address) {
                if (c == '.') {
                    ss.Append("[.]");
                } else {
                    ss.Append(c);
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DefangIPaddr("1.1.1.1");
        Console.WriteLine(ans);
    }
}