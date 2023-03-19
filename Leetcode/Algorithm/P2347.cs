/*
 * Author: Deean
 * Date: 2023-03-19 09:42:54
 * FileName: P2347.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2347 {
    public class Solution {
        public string BestHand(int[] ranks, char[] suits) {
            HashSet<char> set = new HashSet<char>();
            foreach (var suit in suits) {
                set.Add(suit);
            }
            if (set.Count == 1) return "Flush";

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var rank in ranks) {
                if (dict.ContainsKey(rank)) {
                    dict[rank] += 1;
                } else {
                    dict.Add(rank, 1);
                }
            }

            return dict.Values.Max() switch {
                >= 3 => "Three of a Kind",
                2 => "Pair",
                _ => "High Card"
            };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BestHand(new[] { 13, 2, 3, 1, 9 }, new[] { 'a', 'a', 'a', 'a', 'a' });
        Console.WriteLine(ans);
    }
}