/*
 * Author: Deean
 * Date: 2023-03-18 18:42:35
 * FileName: P2496.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2496 {
    public class Solution {
        public int MaximumValue(string[] strs) {
            int n = strs.Length;
            int[] value = new int[n];
            for (int i = 0; i < n; i++) {
                int v = 0;
                for (int j = 0; j < strs[i].Length; j++) {
                    char c = strs[i][j];
                    if (c >= '0' && c <= '9') {
                        v = 10 * v + c - '0';
                    } else {
                        v = strs[i].Length;
                        break;
                    }
                }
                value[i] = v;
            }
            return value.Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximumValue(new[] { "alic3", "bob", "3", "41", "00000" });
        Console.WriteLine(ans);
    }
}