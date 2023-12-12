/*
 * Author: Deean
 * Date: 2023-12-11 22:52:29
 * FileName: LCR0172.cs
 * Description: LCR 172. 统计目标成绩的出现次数
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0172 {
    public class Solution {
        public int CountTarget(int[] scores, int target) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var score in scores) {
                if (!dict.ContainsKey(score)) {
                    dict.Add(score, 0);
                }
                dict[score]++;
            }
            return dict.ContainsKey(target) ? dict[target] : 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountTarget(new[] { 2, 2, 3, 4, 4, 4, 5, 6, 6, 8 }, 4);
        Console.WriteLine(ans);
    }
}