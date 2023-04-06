/*
 * Author: Deean
 * Date: 2023-04-06 23:53:44
 * FileName: P0258.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0258 {
    public class Solution {
        public int AddDigits(int num) {
            while (num >= 10) {
                int sum = 0;
                while (num > 0) {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddDigits(38);
        Console.WriteLine(ans);
    }
}