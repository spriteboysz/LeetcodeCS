/*
 * Author: Deean
 * Date: 2023-04-08 10:46:33
 * FileName: P0067.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P0067 {
    public class Solution {
        public string AddBinary(string a, string b) {
            StringBuilder sum = new StringBuilder();
            for (int pos1 = a.Length - 1, pos2 = b.Length - 1, carry = 0; pos1 >= 0 || pos2 >= 0 || carry > 0;) {
                if (pos1 >= 0) {
                    carry += a[pos1--] - '0';
                }
                if (pos2 >= 0) {
                    carry += b[pos2--] - '0';
                }
                sum.Append(carry % 2);
                carry /= 2;
            }
            char[] cs = sum.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddBinary("1111", "1");
        Console.WriteLine(ans);
    }
}