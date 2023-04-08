/*
 * Author: Deean
 * Date: 2023-04-08 13:24:08
 * FileName: 剑指 Offer 11. 旋转数组的最小数字.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_11__旋转数组的最小数字 {
    public class Solution {
        public int MinArray(int[] numbers) {
            int minimum = numbers[0];
            for (int i = 1, n = numbers.Length; i < n; i++) {
                minimum = Math.Min(minimum, numbers[i]);
            }
            return minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinArray(new[] { 3, 4, 5, 1, 2 });
        Console.WriteLine(ans);
    }
}