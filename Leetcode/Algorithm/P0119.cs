/*
 * Author: Deean
 * Date: 2023-04-08 09:36:55
 * FileName: P0119.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0119 {
    public class Solution {
        public IList<int> GetRow(int rowIndex) {
            IList<int> row = new List<int>();
            row.Add(1);
            for (int i = 1; i <= rowIndex; i++) {
                IList<int> next = new List<int>();
                next.Add(1);
                for (int j = 1; j < i; j++) {
                    next.Add(row[j - 1] + row[j]);
                }
                next.Add(1);
                row = next;
            }
            return row;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetRow(3);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}