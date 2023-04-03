/*
 * Author: Deean
 * Date: 2023-04-03 23:01:22
 * FileName: P0914.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0914 {
    public class Solution {
        private int GCD(int a, int b) {
            return a % b == 0 ? b : GCD(b, a % b);
        }

        public bool HasGroupsSizeX(int[] deck) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in deck) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }

            int maximum = -1;
            foreach (var v in dict.Values) {
                if (maximum == -1) {
                    maximum = v;
                } else {
                    maximum = GCD(maximum, v);
                }
            }
            return maximum >= 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HasGroupsSizeX(new[] { 1, 2, 3, 4, 4, 3, 2, 1 });
        Console.WriteLine(ans);
    }
}