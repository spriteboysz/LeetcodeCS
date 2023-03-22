/*
 * Author: Deean
 * Date: 2023-03-21 23:23:28
 * FileName: P2169.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2169 {
    public class Solution {
        public int CountOperations(int num1, int num2) {
            int cnt = 0;
            while (num1 != 0 && num2 != 0) {
                if (num1 >= num2) {
                    num1 -= num2;
                } else {
                    num2 -= num1;
                }
                cnt++;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountOperations(2, 3);
        Console.WriteLine(ans);
    }
}