/*
 * Author: Deean
 * Date: 2023-11-05 11:20:47
 * FileName: LCR0087.cs
 * Description: LCR 087. 复原 IP 地址
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0087 {
    public class Solution {
        private IList<string> paths = new List<string>();

        bool Check(string str) {
            var value = int.Parse(str);
            if (value > 255 || value < 0 || value.ToString() != str) return false;
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
        Console.WriteLine(ans);
    }
}