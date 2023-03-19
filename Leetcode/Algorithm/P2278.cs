/*
 * Author: Deean
 * Date: 2023-03-19 11:30:40
 * FileName: P2278.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2278 {
    public class Solution {
        public int PercentageLetter(string s, char letter) {
            int cnt = 0;
            foreach (var c in s) {
                if (c == letter) cnt++;
            }
            return cnt * 100 / s.Length;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PercentageLetter("foobar", 'o');
        Console.WriteLine(ans);
    }
}