/*
 * Author: Deean
 * Date: 2023-04-01 21:17:26
 * FileName: P1128.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1128 {
    public class Solution {
        public int NumEquivDominoPairs(int[][] dominoes) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var domino in dominoes) {
                int a = domino[0], b = domino[1];
                string key = "#" + Math.Min(a, b) + "#" + Math.Max(a, b);
                if (dict.ContainsKey(key)) {
                    dict[key] += 1;
                } else {
                    dict.Add(key, 1);
                }
            }
            int cnt = 0;
            foreach (var v in dict.Values) {
                if (v > 1) {
                    cnt += (v - 1) * v / 2;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumEquivDominoPairs(lib.Arrays.To2DArray("[[1,2],[2,1],[3,4],[5,6]]"));
        Console.WriteLine(ans);
    }
}