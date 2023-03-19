/*
 * Author: Deean
 * Date: 2023-03-18 22:54:30
 * FileName: P2418.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2418 {
    public class Solution {
        public string[] SortPeople(string[] names, int[] heights) {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < names.Length; i++) {
                dic.Add(heights[i], names[i]);
            }
            var query = dic.OrderByDescending(dic => dic.Key);
            int index = 0;
            foreach (var q in query) {
                names[index++] = q.Value;
            }
            return names;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortPeople(new[] { "Mary", "John", "Emma" }, new[] { 180, 165, 170 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}