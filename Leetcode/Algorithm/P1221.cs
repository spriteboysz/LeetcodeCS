/*
 * Author: Deean
 * Date: 2023-04-01 22:44:29
 * FileName: P1221.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1221 {
    public class Solution {
        public int BalancedStringSplit(string s) {
            int cnt = 0, balance = 0;
            foreach (var c in s) {
                if (c == 'R') {
                    balance++;
                } else {
                    balance--;
                }
                if (balance == 0) cnt++;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BalancedStringSplit("RLRRRLLRLL");
        Console.WriteLine(ans);
    }
}