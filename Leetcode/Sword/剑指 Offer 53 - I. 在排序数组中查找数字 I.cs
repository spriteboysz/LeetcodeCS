/*
 * Author: Deean
 * Date: 2023-04-08 16:13:22
 * FileName: 剑指 Offer 53 - I. 在排序数组中查找数字 I.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_53___I__在排序数组中查找数字_I {
    public class Solution {
        public int Search(int[] nums, int target) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            return dict.ContainsKey(target) ? dict[target] : 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Search(new[] { 5, 7, 7, 8, 8, 10 }, 8);
        Console.WriteLine(ans);
    }
}