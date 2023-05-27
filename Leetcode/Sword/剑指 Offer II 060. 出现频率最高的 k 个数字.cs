/*
 * Author: Deean
 * Date: 2023-05-26 22:48:52
 * FileName: 剑指 Offer II 060. 出现频率最高的 k 个数字.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_II_060__出现频率最高的_k_个数字 {
    public class Solution {
        public int[] TopKFrequent(int[] nums, int k) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict[num] = 0;
                }
                dict[num] += 1;
            }
            int[] keys = dict.Keys.ToArray();
            Array.Sort(keys, (a, b) => dict[b] - dict[a]);
            IList<int> top = new List<int>();
            for (int i = 0; i < k; i++) {
                top.Add(keys[i]);
            }
            return top.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TopKFrequent(new[] { 3,0,1,0 }, 1);
        Console.WriteLine(Arrays.ToString(ans));
    }
}