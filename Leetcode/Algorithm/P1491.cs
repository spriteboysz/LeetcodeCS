/*
 * Author: Deean
 * Date: 2023-03-26 23:58:23
 * FileName: P1491.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1491 {
    public class Solution {
        public double Average(int[] salary) {
            return (salary.Sum() - salary.Min() - salary.Max()) * 1.0 / (salary.Length - 2);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Average(new[] { 4000, 3000, 1000, 2000 });
        Console.WriteLine(ans);
    }
}