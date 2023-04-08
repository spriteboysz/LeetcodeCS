/*
 * Author: Deean
 * Date: 2023-04-08 16:58:54
 * FileName: 剑指 Offer II 002. 二进制加法.cs
 * Description:
*/

using System;
using System.Text;

namespace Sword;

public class 剑指_Offer_II_002__二进制加法 {
    public class Solution {
        public string AddBinary(string a, string b) {
            StringBuilder ss = new StringBuilder();
            for (int pos1 = a.Length - 1, pos2 = b.Length - 1, carry = 0;
                 pos1 >= 0 || pos2 >= 0 || carry > 0;) {
                if (pos1 >= 0) carry += a[pos1--] - '0';
                if (pos2 >= 0) carry += b[pos2--] - '0';
                ss.Append(carry % 2);
                carry >>= 1;
            }
            char[] cs = ss.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddBinary("1111", "11");
        Console.WriteLine(ans);
    }
}