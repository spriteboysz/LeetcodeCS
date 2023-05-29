/*
 * Author: Deean
 * Date: 2023-05-28 23:04:56
 * FileName: P0047.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0047 {
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
            visited = new bool[nums.Length];
            Array.Sort(nums);
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