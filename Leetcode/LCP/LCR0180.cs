/*
 * Author: Deean
 * Date: 2023-12-19 22:41:34
 * FileName: LCR0180.cs
 * Description: LCR 180. 文件组合
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP;

public class LCR0180 {
    public class Solution {
        public int[][] FileCombination(int target) {
            IList<int[]> sequences = new List<int[]>();
            int left = 1, right = 2;
            while (left < right) {
                int sum = (left + right) * (right - left + 1) / 2;
                if (sum > target) {
                    left++;
                } else if (sum < target) {
                    right++;
                } else {
                    int[] seq = new int[right - left + 1];
                    for (int i = 0; i < right - left + 1; i++) {
                        seq[i] = left + i;
                    }
                    sequences.Add(seq);
                    left++;
                }
            }
            return sequences.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FileCombination(14);
        Console.WriteLine(ans);
    }
}