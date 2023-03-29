/*
 * Author: Deean
 * Date: 2023-03-29 23:33:43
 * FileName: P1394.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1394 {
    public class Solution {
        public int FindLucky(int[] arr) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in arr) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
            }
            int[] keys = dict.Keys.ToArray();
            Array.Sort(keys, (a, b) => b - a);
            foreach (var key in keys) {
                if (key == dict[key]) {
                    return key;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindLucky(new[] { 1, 2, 2, 3, 3, 3 });
        Console.WriteLine(ans);
    }
}