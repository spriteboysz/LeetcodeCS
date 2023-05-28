/*
 * Author: Deean
 * Date: 2023-05-28 12:22:01
 * FileName: P0078.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0078 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int[] nums, int pos) {
            if (pos == nums.Length) {
                paths.Add(new List<int>(path));
            } else {
                backtrace(nums, pos + 1);
                path.Add(nums[pos]);
                backtrace(nums, pos + 1);
                path.RemoveAt(path.Count - 1);
            }
        }

        public IList<IList<int>> Subsets(int[] nums) {
            backtrace(nums, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Subsets(new[] { 1, 2, 3 });
        Console.WriteLine(ans);
    }
}