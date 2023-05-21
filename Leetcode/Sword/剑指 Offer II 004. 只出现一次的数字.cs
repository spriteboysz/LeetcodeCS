/*
 * Author: Deean
 * Date: 2023-05-21 10:50:52
 * FileName: 剑指 Offer II 004. 只出现一次的数字.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_004__只出现一次的数字 {
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
        var ans = s.SingleNumber(new[] { 0, 1, 0, 1, 0, 1, 100 });
        Console.WriteLine(ans);
    }
}