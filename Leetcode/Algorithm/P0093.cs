/*
 * Author: Deean
 * Date: 2023-05-30 23:17:20
 * FileName: P0093.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0093 {
    public class Solution {
        IList<string> paths = new List<string>();

        private bool Check(string s) {
            var value = int.Parse(s);
            if (value > 255 || value < 0 || value.ToString() != s) {
                return false;
            }
            return true;
        }

        private void backtrace(string s, int pos, int level, string path) {
            if (level > 4) return;
            if (level == 4 && pos == s.Length) {
                paths.Add(path);
                return;
            }
            for (int i = pos; i < s.Length && i < pos + 3; i++) {
                var sub = s.Substring(pos, i - pos + 1);
                if (Check(sub)) {
                    backtrace(s, i + 1, level + 1, level == 0 ? path + sub : path + "." + sub);
                }
            }
        }

        public IList<string> RestoreIpAddresses(string s) {
            backtrace(s, 0, 0, "");
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RestoreIpAddresses("25525511135");
        Console.WriteLine(Arrays.ToString(ans));
    }
}