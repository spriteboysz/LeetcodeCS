/*
 * Author: Deean
 * Date: 2023-05-28 20:55:03
 * FileName: 剑指 Offer II 083. 没有重复元素集合的全排列.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_083__没有重复元素集合的全排列 {
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