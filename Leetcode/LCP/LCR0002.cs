/*
 * Author: Deean
 * Date: 2023-10-20 22:34:04
 * FileName: LCR0002.cs
 * Description: LCR 002. 二进制求和
 */

using System;
using System.Text;

namespace LCP;

public class LCR0002 {
    public class Solution {
        public string AddBinary(string a, string b) {
            StringBuilder ss = new StringBuilder();
            int pos1 = a.Length - 1, pos2 = b.Length - 1, carry = 0;
            while (pos1 >= 0 || pos2 >= 0 || carry > 0) {
                if (pos1 >= 0) {
                    carry += a[pos1] - '0';
                    pos1--;
                }
                if (pos2 >= 0) {
                    carry += b[pos2] - '0';
                    pos2--;
                }
                ss.Insert(0, (carry % 2).ToString());
                carry /= 2;
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddBinary("1111", "1");
        Console.WriteLine(ans);
    }
}