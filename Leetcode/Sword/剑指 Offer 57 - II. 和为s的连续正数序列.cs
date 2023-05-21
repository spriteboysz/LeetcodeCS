/*
 * Author: Deean
 * Date: 2023-05-20 23:01:56
 * FileName: 剑指 Offer 57 - II. 和为s的连续正数序列.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword;

public class 剑指_Offer_57___II__和为s的连续正数序列 {
    public class Solution {
        public int[][] FindContinuousSequence(int target) {
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
        var ans = s.FindContinuousSequence(15);
        Console.WriteLine(ans);
    }
}