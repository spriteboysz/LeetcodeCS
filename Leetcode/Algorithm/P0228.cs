/*
 * Author: Deean
 * Date: 2023-04-07 20:53:35
 * FileName: P0228.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0228 {
    public class Solution {
        private string Process(int a, int b) {
            return a == b ? $"{a}" : $"{a}->{b}";
        }

        public IList<string> SummaryRanges(int[] nums) {
            IList<string> summary = new List<string>();
            int n = nums.Length, i = 0;
            while (i < n) {
                int start = nums[i++];
                while (i < n && nums[i - 1] + 1 == nums[i]) {
                    i++;
                }
                int end = nums[i - 1];
                summary.Add(Process(start, end));
            }
            return summary;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 });
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}