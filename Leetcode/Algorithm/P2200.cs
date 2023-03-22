/*
 * Author: Deean
 * Date: 2023-03-22 22:20:29
 * FileName: P2200.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2200 {
    public class Solution {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
            IList<int> indices = new List<int>();
            int n = nums.Length;
            for (int fast = 0, slow = 0; fast < n; fast++) {
                if (nums[fast] == key) {
                    slow = Math.Max(slow, fast - k);
                    int end = Math.Min(fast + k, n - 1);
                    while (slow <= end) {
                        indices.Add(slow++);
                    }
                }
            }
            return indices;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindKDistantIndices(new[] { 3, 4, 9, 1, 3, 9, 5 }, 9, 1);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}