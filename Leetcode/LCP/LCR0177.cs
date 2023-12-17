/*
 * Author: Deean
 * Date: 2023-12-16 21:48:50
 * FileName: LCR0177.cs
 * Description: LCR 177. 撞色搭配
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP;

public class LCR0177 {
    public class Solution {
        public int[] SockCollocation(int[] sockets) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var socket in sockets) {
                if (!dict.ContainsKey(socket)) {
                    dict.Add(socket, 0);
                }
                dict[socket]++;
            }
            IList<int> single = new List<int>();
            foreach (var kv in dict) {
                if (kv.Value == 1) single.Add(kv.Key);
            }
            return single.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SockCollocation(new[] { 4, 5, 2, 4, 6, 6 });
        Console.WriteLine(ans);
    }
}