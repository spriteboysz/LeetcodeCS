/*
 * Author: Deean
 * Date: 2023-05-19 22:51:15
 * FileName: P2609.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P2609 {
    public class Solution {
        public int FindTheLongestBalancedSubstring(string s) {
            for (int i = 25; i >= 0; i--) {
                StringBuilder ss = new StringBuilder();
                for (int j = 0; j < i; j++) {
                    ss.Append(0);
                }
                for (int j = 0; j < i; j++) {
                    ss.Append(1);
                }
                if (s.Contains(ss.ToString())) {
                    return i * 2;
                }
            }
            return 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTheLongestBalancedSubstring("01000111");
        Console.WriteLine(ans);
    }
}