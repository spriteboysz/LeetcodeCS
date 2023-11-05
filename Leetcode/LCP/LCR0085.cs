/*
 * Author: Deean
 * Date: 2023-11-03 21:24:56
 * FileName: LCR0085.cs
 * Description: LCR 085. 括号生成
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace LCP;

public class LCR0085 {
    public class Solution {
        private IList<string> paths = new List<string>();
        private StringBuilder path = new();

        private void backtrace(int n, int left, int right) {
            if (path.Length == n * 2) {
                paths.Add(path.ToString());
                return;
            }
            if (left < n) {
                path.Append("(");
                backtrace(n, left + 1, right);
                path.Remove(path.Length - 1, 1);
            }
            if (right < left) {
                path.Append(")");
                backtrace(n, left, right + 1);
                path.Remove(path.Length - 1, 1);
            }
        }

        public IList<string> GenerateParenthesis(int n) {
            backtrace(n, 0, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GenerateParenthesis(3);
        Console.WriteLine(ans);
    }
}