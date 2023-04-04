/*
 * Author: Deean
 * Date: 2023-04-04 13:23:20
 * FileName: P0657.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0657 {
    public class Solution {
        public bool JudgeCircle(string moves) {
            int x = 0, y = 0;
            foreach (var move in moves) {
                switch (move) {
                    case 'R':
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                }
            }
            return x == 0 && y == 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.JudgeCircle("UD");
        Console.WriteLine(ans);
    }
}