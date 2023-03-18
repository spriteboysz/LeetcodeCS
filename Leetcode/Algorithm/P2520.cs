/*
 * Author: Deean
 * Date: 2023-03-18 17:03:50
 * FileName: P2520.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2520 {
    public class Solution {
        public int CountDigits(int num) {
            int cnt = 0, temp = num;
            while (temp > 0) {
                if (num % (temp % 10) == 0) {
                    cnt++;
                }
                temp /= 10;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountDigits(121);
        Console.WriteLine(ans);
    }
}