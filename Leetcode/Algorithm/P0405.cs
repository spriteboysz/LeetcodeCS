/*
 * Author: Deean
 * Date: 2023-04-05 22:07:43
 * FileName: P0405.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P0405 {
    public class Solution {
        public string ToHex(int num) {
            if (num == 0) return "0";
            StringBuilder ss = new StringBuilder();
            for (int i = 8 - 1; i >= 0; i--) {
                int val = (num >> (4 * i)) & 0xf;
                if (ss.Length > 0 || val > 0) {
                    ss.Append(val < 10 ? (char)('0' + val) : (char)('a' + val - 10));
                }
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ToHex(26);
        Console.WriteLine(ans);
        Console.WriteLine(s.ToHex(-1));
    }
}