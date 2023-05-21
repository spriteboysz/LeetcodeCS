/*
 * Author: Deean
 * Date: 2023-05-20 22:57:55
 * FileName: 剑指 Offer 56 - II. 数组中数字出现的次数 II.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_56___II__数组中数字出现的次数_II {
    public class Solution {
        public int SingleNumber(int[] nums) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            foreach (var kv in dict) {
                if (kv.Value == 1) return kv.Key;
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNumber(new[] { 9, 1, 7, 9, 7, 9, 7 });
        Console.WriteLine(ans);
    }
}