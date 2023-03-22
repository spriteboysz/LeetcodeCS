/*
 * Author: Deean
 * Date: 2023-03-21 23:49:18
 * FileName: P2194.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P2194 {
    public class Solution {
        public IList<string> CellsInRange(string s) {
            IList<string> cells = new List<string>();
            StringBuilder ss = new StringBuilder();
            for (int i = s[0]; i <= s[3]; i++) {
                for (int j = s[1]; j <= s[4]; j++) {
                    ss.Append((char)(i)).Append((char)(j));
                    cells.Add(ss.ToString());
                    ss.Remove(0, 2);
                }
            }
            return cells;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CellsInRange("K1:L2");
        Console.WriteLine(ans);
    }
}