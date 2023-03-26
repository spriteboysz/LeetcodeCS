/*
 * Author: Deean
 * Date: 2023-03-25 22:12:46
 * FileName: P1796.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1796 {
    public class Solution {
        public int SecondHighest(string s) {
            int[] hash = new int[10];
            foreach (var c in s.Where(c => c is >= '0' and <= '9')) {
                hash[c - '0'] |= 1;
            }

            int max1 = 10, max2 = 10;
            for (int i = 10 - 1; i >= 0; i--) {
                if (max1 == 10 && hash[i] == 1) {
                    max1 = i;
                } else if (hash[i] == 1) {
                    max2 = i;
                    break;
                }
            }
            return max2 == 10 ? -1 : max2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SecondHighest("ck077");
        Console.WriteLine(ans);
    }
}