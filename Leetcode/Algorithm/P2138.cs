/*
 * Author: Deean
 * Date: 2023-03-20 23:51:02
 * FileName: P2138.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P2138 {
    public class Solution {
        public string[] DivideString(string s, int k, char fill) {
            List<string> divide = new List<string>();
            StringBuilder ss = new StringBuilder();
            foreach (var c in s) {
                if (ss.Length < k) {
                    ss.Append(c);
                }
                if (ss.Length == k) {
                    divide.Add(ss.ToString());
                    ss.Remove(0, k);
                }
            }
            if (ss.Length > 0) {
                ss.Append(fill, k - ss.Length);
                divide.Add(ss.ToString());
            }
            return divide.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DivideString("abcdefghi", 3, 'x');
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}