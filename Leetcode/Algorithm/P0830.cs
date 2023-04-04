/*
 * Author: Deean
 * Date: 2023-04-04 09:51:00
 * FileName: P0830.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0830 {
    public class Solution {
        public IList<IList<int>> LargeGroupPositions(string s) {
            IList<IList<int>> groups = new List<IList<int>>();
            for (int i = 0; i < s.Length;) {
                int start = i;
                while (i < s.Length && s[i] == s[start]) {
                    i++;
                }
                if (i - start >= 3) {
                    groups.Add(new[] { start, i - 1 }.ToList());
                }
            }
            return groups;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargeGroupPositions("abcdddeeeeaabbbcd");
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}