/*
 * Author: Deean
 * Date: 2023-03-28 22:51:24
 * FileName: P1556.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1556 {
    public class Solution {
        public string ThousandSeparator(int n) {
            if (n == 0) return "0";
            Stack<char> ss = new Stack<char>();
            int pos = 0;
            while (n > 0) {
                if (pos == 3) {
                    ss.Push('.');
                    pos = 0;
                }
                ss.Push((char)(n % 10 + '0'));
                pos++;
                n /= 10;
            }
            return new string(ss.ToArray());
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ThousandSeparator(1234);
        Console.WriteLine(ans);
    }
}