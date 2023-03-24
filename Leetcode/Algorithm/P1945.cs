/*
 * Author: Deean
 * Date: 2023-03-23 22:56:55
 * FileName: P1945.cs
 * Description:
*/

using System;
using System.Linq;
using System.Text;

namespace Algorithm; 

public class P1945 {
    public class Solution {
        public int GetLucky(string s, int k) {
            StringBuilder ss = new StringBuilder();
            foreach (var c in s) {
                ss.Append(c - 'a' + 1);
            }
            string num = ss.ToString();
            while (k > 0) {
                int sum = num.Sum(c => c - '0');
                num = sum.ToString();
                k--;
            }
            return num.Aggregate(0, (current, c) => current * 10 + c - '0');
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetLucky("leetcode", 2);
        Console.WriteLine(ans);
    }
}