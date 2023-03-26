/*
 * Author: Deean
 * Date: 2023-03-26 23:48:17
 * FileName: P1475.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1475 {
    public class Solution {
        public int[] FinalPrices(int[] prices) {
            int n = prices.Length;
            int[] final = new int[n];
            for (int i = 0; i < n; i++) {
                final[i] = prices[i];
                for (int j = i + 1; j < n; j++) {
                    if (prices[i] >= prices[j]) {
                        final[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }
            return final;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FinalPrices(new []{8,4,6,2,3});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}