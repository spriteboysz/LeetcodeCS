/*
 * Author: Deean
 * Date: 2023-12-17 10:49:51
 * FileName: LCR0178.cs
 * Description: LCR 178. 训练计划 VI
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0178 {
    public class Solution {
        public int TrainingPlan(int[] actions) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var action in actions) {
                if (!dict.ContainsKey(action)) {
                    dict.Add(action, 0);
                }
                dict[action]++;
            }
            foreach (var kv in dict) {
                if (kv.Value == 1) return kv.Key;
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrainingPlan(new[] { 5, 7, 5, 5 });
        Console.WriteLine(ans);
    }
}