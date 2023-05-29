/*
 * Author: Deean
 * Date: 2023-05-28 20:48:07
 * FileName: P0040.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0040 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int[] candidates, int sum, int target, int pos) {
            if (sum > target) return;
            if (sum == target) {
                paths.Add(new List<int>(path));
                return;
            }
            for (int i = pos; i < candidates.Length; i++) {
                if (i > pos && candidates[i] == candidates[i - 1]) {
                    continue;
                }
                path.Add(candidates[i]);
                backtrace(candidates, sum + candidates[i], target, i + 1);
                path.RemoveAt(path.Count - 1);
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
        Console.WriteLine(ans);
    }
}