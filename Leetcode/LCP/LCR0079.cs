/*
 * Author: Deean
 * Date: 2023-10-28 22:10:53
 * FileName: LCR0079.cs
 * Description: LCR 079. 子集
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0079 {
    public class Solution {
        private IList<IList<int>> paths;
        private IList<int> path;

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
            paths = new List<IList<int>>();
            path = new List<int>();
            backtrace(nums, 0);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Subsets(new[] { 1, 2, 3 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}