/*
 * Author: Deean
 * Date: 2023-04-07 23:19:14
 * FileName: P0202.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0202 {
    public class Solution {
        public bool IsHappy(int n) {
            HashSet<int> set = new HashSet<int> { n };
            while (n != 1) {
                int sum = 0;
                while (n > 0) {
                    int cur = n % 10;
                    sum += cur * cur;
                    n /= 10;
                }
                if (set.Contains(sum)) {
                    return false;
                }
                set.Add(sum);
                n = sum;
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsHappy(19);
        Console.WriteLine(ans);
    }
}