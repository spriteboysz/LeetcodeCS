/*
 * Author: Deean
 * Date: 2023-04-05 15:52:08
 * FileName: P0507.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0507 {
    public class Solution {
        public bool CheckPerfectNumber(int num) {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++) {
                if (num % i == 0) {
                    sum += i;
                }
            }
            return sum == num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckPerfectNumber(28);
        Console.WriteLine(ans);
    }
}