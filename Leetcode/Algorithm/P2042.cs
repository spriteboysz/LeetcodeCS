/*
 * Author: Deean
 * Date: 2023-03-19 20:05:28
 * FileName: P2042.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2042 {
    public class Solution {
        public bool AreNumbersAscending(string s) {
            int pre = 0, pos = 0;
            while (pos < s.Length) {
                if (char.IsDigit(s[pos])) {
                    int cur = 0;
                    while (pos < s.Length && char.IsDigit(s[pos])) {
                        cur = cur * 10 + s[pos++] - '0';
                    }
                    if (cur <= pre) {
                        return false;
                    }
                    pre = cur;
                } else {
                    pos++;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AreNumbersAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles");
        Console.WriteLine(ans);
    }
}