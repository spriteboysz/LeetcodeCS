/*
 * Author: Deean
 * Date: 2023-03-21 22:59:26
 * FileName: P2160.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2160 {
    public class Solution {
        public int MinimumSum(int num) {
            char[] digits = num.ToString().ToCharArray();
            Array.Sort(digits);
            return (digits[0] + digits[1]) * 10 + digits[2] + digits[3] - '0' * 22;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumSum(2932);
        Console.WriteLine(ans);
    }
}