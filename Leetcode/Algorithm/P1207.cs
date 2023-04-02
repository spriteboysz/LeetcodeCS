/*
 * Author: Deean
 * Date: 2023-04-01 22:38:26
 * FileName: P1207.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1207 {
    public class Solution {
        public bool UniqueOccurrences(int[] arr) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in arr) {
                if (dict.ContainsKey(num)) {
                    dict[num]++;
                } else {
                    dict.Add(num, 1);
                }
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var v in dict.Values) {
                set.Add(v);
            }
            return set.Count == dict.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.UniqueOccurrences(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
        Console.WriteLine(ans);
    }
}