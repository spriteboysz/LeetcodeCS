/*
 * Author: Deean
 * Date: 2023-08-16 21:26:24
 * FileName: P2810.cs
 * Description:2810. 故障键盘
 */

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P2810 {
    public class Solution {
        public string FinalString(string s) {
            List<string> ss = new List<string>();
            foreach (var c in s) {
                if (c == 'i') {
                    ss.Reverse();
                } else {
                    ss.Add(c.ToString());
                }
            }
            return String.Concat(ss);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FinalString("string");
        Console.WriteLine(Arrays.ToString(ans));
    }
}