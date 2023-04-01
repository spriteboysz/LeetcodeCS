/*
 * Author: Deean
 * Date: 2023-03-31 23:20:51
 * FileName: P1071.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1071 {
    public class Solution {
        private int Gcd(int a, int b) {
            return b == 0 ? a : Gcd(b, a % b);
        }

        public string GcdOfStrings(string str1, string str2) {
            if (str1 + str2 != str2 + str1) {
                return "";
            }
            int n1 = str1.Length, n2 = str2.Length;
            return str1.Substring(0, Gcd(n1, n2));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GcdOfStrings("ABABAB", "ABAB");
        Console.WriteLine(ans);
    }
}