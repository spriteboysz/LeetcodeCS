/*
 * Author: Deean
 * Date: 2023-11-01 20:56:48
 * FileName: LCR0083.cs
 * Description: LCR 083. 全排列
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0083 {
    public class Solution {
        private IList<IList<int>> paths = new List<IList<int>>();
        private IList<int> path = new List<int>();

        private void backtrace(int[] nums, HashSet<int> hash) {
            if (path.Count == nums.Length) {
                paths.Add(new List<int>(path));
                return;
            }
            foreach (var num in nums) {
                if (hash.Contains(num)) continue;
                hash.Add(num);
                path.Add(num);
                backtrace(nums, hash);
                path.RemoveAt(path.Count - 1);
                hash.Remove(num);
            }
        }

        public IList<IList<int>> Permute(int[] nums) {
            HashSet<int> hash = new HashSet<int>();
            backtrace(nums, hash);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Permute(new[] { 1, 2, 3 });
        Console.WriteLine(ans);
    }
}