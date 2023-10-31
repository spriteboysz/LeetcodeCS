﻿/*
 * Author: Deean
 * Date: 2023-10-29 10:27:35
 * FileName: LCR0080.cs
 * Description: LCR 080. 组合
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0080 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int n, int k, int pos) {
            if (path.Count == k) {
                paths.Add(new List<int>(path));
            } else {
                if (path.Count + n - pos + 1 < k) {
                    return;
                }
                path.Add(pos);
                backtrace(n, k, pos + 1);
                path.RemoveAt(path.Count - 1);
                backtrace(n, k, pos + 1);
            }
        }

        public IList<IList<int>> Combine(int n, int k) {
            backtrace(n, k, 1);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Combine(4, 2);
        Console.WriteLine(ans);
    }
}