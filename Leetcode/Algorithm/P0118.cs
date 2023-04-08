/*
 * Author: Deean
 * Date: 2023-04-08 09:42:38
 * FileName: P0118.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0118 {
    public class Solution {
        public IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> triangle = new List<IList<int>>();
            IList<int> row = new List<int>();
            row.Add(1);
            triangle.Add(row);
            for (int i = 1; i < numRows; i++) {
                IList<int> next = new List<int>();
                next.Add(1);
                for (int j = 1; j < i; j++) {
                    next.Add(row[j - 1] + row[j]);
                }
                next.Add(1);
                row = next;
                triangle.Add(row);
            }
            return triangle;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Generate(3);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}