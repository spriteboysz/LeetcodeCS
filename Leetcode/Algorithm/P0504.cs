/*
 * Author: Deean
 * Date: 2023-04-04 22:56:04
 * FileName: P0504.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm; 

public class P0504 {
    public class Solution {
        public string ConvertToBase7(int num) {
            if (num == 0) return "0";
            bool negative = num < 0;
            num = Math.Abs(num);
            StringBuilder ss = new StringBuilder();
            while (num > 0) {
                ss.Append(num % 7);
                num /= 7;
            }
            if (negative) ss.Append("-");
            char[] cs = ss.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertToBase7(100);
        Console.WriteLine(ans);
    }
}