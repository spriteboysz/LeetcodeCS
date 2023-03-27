/*
 * Author: Deean
 * Date: 2023-03-27 22:47:28
 * FileName: P1496.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1496 {
    public class Solution {
        public bool IsPathCrossing(string path) {
            HashSet<string> visited = new HashSet<string>();
            int x = 0, y = 0;
            visited.Add($"#{x}#{y}");
            foreach (var step in path) {
                switch (step) {
                    case 'N':
                        y += 1;
                        break;
                    case 'S':
                        y -= 1;
                        break;
                    case 'E':
                        x += 1;
                        break;
                    case 'W':
                        x -= 1;
                        break;
                    default:
                        return false;
                }
                if (visited.Contains($"#{x}#{y}")) {
                    return true;
                }
                visited.Add($"#{x}#{y}");
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPathCrossing("NESWW");
        Console.WriteLine(ans);
    }
}