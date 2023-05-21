/*
 * Author: Deean
 * Date: 2023-05-21 10:17:48
 * FileName: 剑指 Offer 64. 求1+2+…+n.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_64__求1_2___n {
    public class Solution {
        public int SumNums(int n) {
            if (n == 1) return 1;
            return SumNums(n - 1) + n;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumNums(9);
        Console.WriteLine(ans);
    }
}