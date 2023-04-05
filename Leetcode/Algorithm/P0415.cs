/*
 * Author: Deean
 * Date: 2023-04-05 19:44:00
 * FileName: P0415.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P0415 {
    public class Solution {
        public string AddStrings(string num1, string num2) {
            StringBuilder sum = new StringBuilder();
            int pos1 = num1.Length - 1, pos2 = num2.Length - 1, carry = 0;
            for (; pos1 >= 0 && pos2 >= 0; pos1--, pos2--) {
                carry += num1[pos1] - '0' + num2[pos2] - '0';
                sum.Append(carry % 10);
                carry /= 10;
            }
            for (; pos1 >= 0 || pos2 >= 0; pos1--, pos2--) {
                if (pos1 >= 0) carry += num1[pos1] - '0';
                if (pos2 >= 0) carry += num2[pos2] - '0';
                sum.Append(carry % 10);
                carry /= 10;
            }
            if (carry > 0) {
                sum.Append(carry);
            }
            char[] cs = sum.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddStrings("9999", "3");
        Console.WriteLine(ans);
    }
}