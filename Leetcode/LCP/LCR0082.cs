/*
 * Author: Deean
 * Date: 2023-10-31 22:55:37
 * FileName: LCR0082.cs
 * Description: LCR 082. 组合总和 II
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0082 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int[] candidates, int sum, int target, int index) {
            if (sum > target) return;
            if (sum == target) {
                paths.Add(new List<int>(path));
                return;
            }
            for (int i = index; i < candidates.Length; i++) {
                if (i > index && candidates[i] == candidates[i - 1]) {
                    continue;
                }
                sum += candidates[i];
                path.Add(candidates[i]);
                backtrace(candidates, sum, target, i + 1);
                path.RemoveAt(path.Count - 1);
                sum -= candidates[i];
            }
        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
            Array.Sort(candidates);
            backtrace(candidates, 0, target, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CombinationSum2(new[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
        Console.WriteLine(Arrays.ToString(ans));
    }
}