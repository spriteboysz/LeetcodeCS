/*
 * Author: Deean
 * Date: 2023-04-04 16:11:04
 * FileName: P0682.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0682 {
    public class Solution {
        public int CalPoints(string[] operations) {
            IList<int> points = new List<int>();
            foreach (var operation in operations) {
                int n = points.Count;
                switch (operation) {
                    case "+":
                        points.Add(points[n - 2] + points[n - 1]);
                        break;
                    case "D":
                        points.Add(points[n - 1] * 2);
                        break;
                    case "C":
                        points.RemoveAt(n - 1);
                        break;
                    default:
                        points.Add(int.Parse(operation));
                        break;
                }
            }
            return points.ToArray().Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CalPoints(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" });
        Console.WriteLine(ans);
    }
}