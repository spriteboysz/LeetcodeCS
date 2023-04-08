/*
 * Author: Deean
 * Date: 2023-04-08 13:19:42
 * FileName: 剑指 Offer 10- II. 青蛙跳台阶问题.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_10__II__青蛙跳台阶问题 {
    public class Solution {
        public int NumWays(int n) {
            const int MOD = 1000000007; 
            if (n <= 1) return 1;
            int a = 1, b = 1, num = 0;
            for (int i = 2; i <= n; i++) {
                num = (a + b) % MOD;
                a = b;
                b = num;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumWays(7);
        Console.WriteLine(ans);
    }
}