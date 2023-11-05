/*
 * Author: Deean
 * Date: 2023-11-04 14:56:09
 * FileName: LCR0086.cs
 * Description: LCR0086
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP;

public class LCR0086 {
    public class Solution {
        private IList<string[]> paths = new List<string[]>();
        private IList<string> path = new List<string>();

        private bool Check(string s, int left, int right) {
            while (left < right) {
                if (s[left++] != s[right--]) {
                    return false;
                }
            }
            return true;
        }

        private void backtrace(string s, int left, int right) {
            if (left == s.Length) {
                paths.Add(new List<string>(path).ToArray());
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

        public string[][] Partition(string s) {
            backtrace(s, 0, 0);
            return paths.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Partition("google");
        Console.WriteLine(ans);
    }
}