/*
 * Author: Deean
 * Date: 2023-05-20 22:52:49
 * FileName: 剑指 Offer 56 - I. 数组中数字出现的次数.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_56___I__数组中数字出现的次数 {
    public class Solution {
        public int[] SingleNumbers(int[] nums) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            IList<int> single = new List<int>();
            foreach (var kv in dict) {
                if (kv.Value == 1) single.Add(kv.Key);
            }
            return single.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SingleNumbers(new[] { 1, 2, 10, 4, 1, 4, 3, 3 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}