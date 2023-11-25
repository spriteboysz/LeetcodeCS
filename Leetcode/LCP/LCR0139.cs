/*
 * Author: Deean
 * Date: 2023-11-21 23:28:20
 * FileName: LCR0139.cs
 * Description: LCR 139. 训练计划 I
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP;

public class LCR0139 {
    public class Solution {
        public int[] TrainingPlan(int[] actions) {
            IList<int> odd = new List<int>(), even = new List<int>();
            foreach (var action in actions) {
                if (action % 2 == 0) {
                    even.Add(action);
                } else {
                    odd.Add(action);
                }
            }
            return odd.Concat(even).ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrainingPlan(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine(ans);
    }
}