/*
 * Author: Deean
 * Date: 2023-05-28 20:28:45
 * FileName: P0039.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0039 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();
        private int[] candidates;

        private void backtrace(int sum, int target, int pos) {
            if (pos >= candidates.Length) return;
            if (sum == target) {
                paths.Add(new List<int>(path));
                return;
            }
            if (sum + candidates[pos] > target) return;
            path.Add(candidates[pos]);
            backtrace(sum + candidates[pos], target, pos);
            path.RemoveAt(path.Count - 1);
            backtrace(sum, target, pos + 1);
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target) {
            this.candidates = candidates;
            Array.Sort(this.candidates);
            backtrace(0, target, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CombinationSum(new[] { 2, 3, 6, 7 }, 7);
        Console.WriteLine(ans);
    }
}