/*
 * Author: Deean
 * Date: 2023-03-18 14:55:21
 * FileName: P2578.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2578 {
    public class Solution {
        public int SplitNum(int num) {
            List<int> digits = new List<int>();
            while (num > 0) {
                digits.Add(num % 10);
                num /= 10;
            }
            digits.Sort();
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < digits.Count; i += 2) {
                sum1 = sum1 * 10 + digits[i];
                if (i == digits.Count - 1) break;
                sum2 = sum2 * 10 + digits[i + 1];
            }
            return sum1 + sum2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SplitNum(2578);
        Console.WriteLine(ans);
    }
}