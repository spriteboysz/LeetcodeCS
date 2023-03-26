/*
 * Author: Deean
 * Date: 2023-03-26 23:35:18
 * FileName: P1464.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1464 {
    public class Solution {
        public int MaxProduct(int[] nums) {
            int max1 = 0, max2 = 0;
            foreach (var num in nums) {
                if (num > max1) {
                    max2 = max1;
                    max1 = num;
                } else if (num > max2) {
                    max2 = num;
                }
            }
            return (max1 - 1) * (max2 - 1);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProduct(new[] { 3, 4, 5, 2 });
        Console.WriteLine(ans);
    }
}