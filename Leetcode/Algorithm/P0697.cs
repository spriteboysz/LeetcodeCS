/*
 * Author: Deean
 * Date: 2023-04-04 15:43:58
 * FileName: P0697.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0697 {
    public class Solution {
        public int FindShortestSubArray(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 1);
                } else {
                    dict[num]++;
                }
            }

            int maxVal = dict.Values.Max();
            List<int> list = new List<int>();
            foreach (var item in dict.Keys) {
                if (dict[item] == maxVal) {
                    list.Add(item);
                }
            }
            int minimum = Int32.MaxValue;
            foreach (var num in list) {
                int start = 0, end = nums.Length - 1;
                for (int j = 0; j < nums.Length; j++) {
                    if (nums[j] == num) {
                        start = j;
                        break;
                    }
                }
                for (int j = nums.Length - 1; j >= 0; j--) {
                    if (nums[j] == num) {
                        end = j;
                        break;
                    }
                }
                minimum = Math.Min(minimum, end - start + 1);
            }
            return minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindShortestSubArray(new[] { 1, 2, 2, 3, 1, 4, 2 });
        Console.WriteLine(ans);
    }
}