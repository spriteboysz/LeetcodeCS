/*
 * Author: Deean
 * Date: 2023-03-19 10:20:44
 * FileName: P2315.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2315 {
    public class Solution {
        public int CountAsterisks(string s) {
            int cnt = 0;
            bool flag = true;
            foreach (var c in s) {
                if (c == '|') {
                    flag = !flag;
                } else if (c == '*' && flag) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountAsterisks("l|*e*et|c**o|*de|");
        Console.WriteLine(ans);
    }
}