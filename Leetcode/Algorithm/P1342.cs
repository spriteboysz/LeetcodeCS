/*
 * Author: Deean
 * Date: 2023-03-30 23:47:29
 * FileName: P1342.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1342 {
    public class Solution {
        public int NumberOfSteps(int num) {
            int cnt = 0;
            while (num > 0) {
                if (num % 2 == 0) {
                    num /= 2;
                } else {
                    num -= 1;
                }
                cnt++;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfSteps(14);
        Console.WriteLine(ans);
    }
}