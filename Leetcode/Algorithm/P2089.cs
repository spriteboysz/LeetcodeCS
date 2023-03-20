/*
 * Author: Deean
 * Date: 2023-03-19 22:47:50
 * FileName: P2089.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2089 {
    public class Solution {
        public IList<int> TargetIndices(int[] nums, int target) {
            Array.Sort(nums);
            IList<int> index = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > target) break;
                if (nums[i] == target) {
                    index.Add(i);
                }
            }
            return index;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TargetIndices(new[] { 1, 2, 5, 2, 3 }, 2);
        Console.WriteLine(ans);
    }
}