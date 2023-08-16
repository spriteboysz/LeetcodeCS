/*
 * Author: Deean
 * Date: 2023-08-16 21:44:29
 * FileName: P2806.cs
 * Description:2806. 取整购买后的账户余额
 */

using System;

namespace Algorithm;

public class P2806 {
    public class Solution {
        public int AccountBalanceAfterPurchase(int purchaseAmount) {
            if (purchaseAmount % 10 <= 4) return 100 - purchaseAmount / 10 * 10;
            return 100 - (purchaseAmount + 9) / 10 * 10;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AccountBalanceAfterPurchase(9);
        Console.WriteLine(ans);
    }
}