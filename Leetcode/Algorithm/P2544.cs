/*
 * Author: Deean
 * Date: 2023-03-18 11:14:20
 * FileName: P2544.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2544 {
    public class Solution {
        public int AlternateDigitSum(int n) {
            int sum = 0, flag = 1, cnt = 0;
            while (n > 0) {
                sum += (n % 10) * flag;
                flag = -flag;
                n /= 10;
                cnt++;
            }

            return cnt % 2 == 1 ? sum : -sum;
        }
    }

    public static void Test()
    {
        var s = new Solution();
        var ans = s.AlternateDigitSum(521);
        Console.WriteLine(ans);
    }
}