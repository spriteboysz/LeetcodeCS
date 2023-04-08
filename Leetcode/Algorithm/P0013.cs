/*
 * Author: Deean
 * Date: 2023-04-08 11:56:15
 * FileName: P0013.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0013 {
    public class Solution {
        public int RomanToInt(string s) {
            Dictionary<char, int> symbol = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int num = 0;
            for (int i = 0, n = s.Length; i < n; i++) {
                int value = symbol[s[i]];
                if (i < n - 1 && value < symbol[s[i + 1]]) {
                    num -= value;
                } else {
                    num += value;
                }
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RomanToInt("LVIII");
        Console.WriteLine(ans);
    }
}