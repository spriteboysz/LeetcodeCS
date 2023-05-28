/*
 * Author: Deean
 * Date: 2023-05-28 12:13:44
 * FileName: 剑指 Offer II 079. 所有子集.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_079__所有子集 {
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
        Console.WriteLine(ans);
    }
}