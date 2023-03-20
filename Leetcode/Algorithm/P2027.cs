/*
 * Author: Deean
 * Date: 2023-03-19 19:52:40
 * FileName: P2027.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2027 {
    public class Solution {
        public int MinimumMoves(string s) {
            int covered = -1, cnt = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'X' && i > covered) {
                    cnt++;
                    covered = i + 2;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumMoves("XXOX");
        Console.WriteLine(ans);
    }
}