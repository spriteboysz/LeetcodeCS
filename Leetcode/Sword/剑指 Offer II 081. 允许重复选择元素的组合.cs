/*
 * Author: Deean
 * Date: 2023-05-28 20:14:51
 * FileName: 剑指 Offer II 081. 允许重复选择元素的组合.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_081__允许重复选择元素的组合 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int[] candidates, int sum, int target, int pos) {
            if (pos >= candidates.Length) return;
            if (sum == target) {
                paths.Add(new List<int>(path));
                return;
            }
            if (sum + candidates[pos] > target) return;
            path.Add(candidates[pos]);
            backtrace(candidates, sum + candidates[pos], target, pos);
            path.RemoveAt(path.Count - 1);
            backtrace(candidates, sum, target, pos + 1);
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target) {
            Array.Sort(candidates);
            backtrace(candidates, 0, target, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CombinationSum(new[] { 2, 3, 6, 7 }, 7);
        Console.WriteLine(ans);
    }
}