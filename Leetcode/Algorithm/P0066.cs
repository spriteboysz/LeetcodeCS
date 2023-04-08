/*
 * Author: Deean
 * Date: 2023-04-08 10:58:08
 * FileName: P0066.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0066 {
    public class Solution {
        public int[] PlusOne(int[] digits) {
            IList<int> ss = new List<int>();
            for (int pos = digits.Length - 1, carry = 1; pos >= 0 || carry > 0; pos--) {
                if (pos >= 0) {
                    carry += digits[pos];
                }
                ss.Add(carry % 10);
                carry /= 10;
            }
            int[] sum = ss.ToArray();
            Array.Reverse(sum);
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PlusOne(new[] { 9, 9, 9, 9 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}