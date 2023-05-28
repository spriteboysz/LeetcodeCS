/*
 * Author: Deean
 * Date: 2023-05-28 20:38:47
 * FileName: 剑指 Offer II 082. 含有重复元素集合的组合.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_082__含有重复元素集合的组合 {
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