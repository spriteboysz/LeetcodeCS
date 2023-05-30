/*
 * Author: Deean
 * Date: 2023-05-29 23:06:26
 * FileName: P0022.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;
using lib;

namespace Algorithm;

public class P0022 {
    public class Solution {
        private IList<string> paths = new List<string>();
        private StringBuilder path = new StringBuilder();

        private void backtrace(int n, int left, int right) {
            if (path.Length == n * 2) {
                paths.Add(path.ToString());
                return;
            }
            if (left < n) {
                path.Append("(");
                backtrace(n, left + 1, right);
                path.Length--;
            }
            if (right < left) {
                path.Append(")");
                backtrace(n, left, right + 1);
                path.Length--;
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
        Console.WriteLine(Arrays.ToString(ans));
    }
}