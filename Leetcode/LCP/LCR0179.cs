/*
 * Author: Deean
 * Date: 2023-12-18 22:45:47
 * FileName: LCR0179.cs
 * Description: LCR 179. 查找总价格为目标值的两个商品
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0179 {
    public class Solution {
        public int[] TwoSum(int[] price, int target) {
            HashSet<int> seen = new HashSet<int>();
            foreach (var num in price) {
                if (seen.Contains(target - num)) {
                    return new[] { num, target - num };
                }
                seen.Add(num);
            }
            return new[] { -1, -1 };

        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TwoSum(new[] { 3, 9, 12, 15 }, 18);
        Console.WriteLine(ans);
    }
}