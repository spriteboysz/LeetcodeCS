/*
 * Author: Deean
 * Date: 2023-11-02 22:44:07
 * FileName: LCR0084.cs
 * Description: LCR 084. 全排列 II
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0084 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();
        private bool[] visited;

        private void backtrace(int[] nums, int pos) {
            if (pos == nums.Length) {
                paths.Add(new List<int>(path));
                return;
            }
            for (int i = 0; i < nums.Length; i++) {
                if (visited[i] || (i > 0 && nums[i] == nums[i - 1] && !visited[i - 1])) {
                    continue;
                }
                path.Add(nums[i]);
                visited[i] = true;
                backtrace(nums, pos + 1);
                path.RemoveAt(path.Count - 1);
                visited[i] = false;
            }
        }

        public IList<IList<int>> PermuteUnique(int[] nums) {
            Array.Sort(nums);
            visited = new bool[nums.Length];
            backtrace(nums, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PermuteUnique(new[] { 1, 1, 2 });
        Console.WriteLine(ans);
    }
}