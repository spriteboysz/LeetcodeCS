/*
 * Author: Deean
 * Date: 2023-05-29 23:28:42
 * FileName: P0131.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0131 {
    public class Solution {
        private IList<IList<string>> paths = new List<IList<string>>();
        private IList<string> path = new List<string>();

        private bool Check(string s, int left, int right) {
            while (left < right) {
                if (s[left++] != s[right--]) return false;
            }
            return true;
        }

        private void backtrace(string s, int left, int right) {
            if (left == s.Length) {
                paths.Add(new List<string>(path));
                return;
            }
            if (right == s.Length) return;
            if (Check(s, left, right)) {
                path.Add(s.Substring(left, right - left + 1));
                backtrace(s, right + 1, right + 1);
                path.RemoveAt(path.Count - 1);
            }
            backtrace(s, left, right + 1);
        }

        public IList<IList<string>> Partition(string s) {
            backtrace(s, 0, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Partition("google");
        Console.WriteLine(ans);
    }
}