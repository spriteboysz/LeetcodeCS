/*
 * Author: Deean
 * Date: 2023-04-08 15:52:34
 * FileName: 剑指 Offer 39. 数组中出现次数超过一半的数字.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_39__数组中出现次数超过一半的数字 {
    public class Solution {
        public int MajorityElement(int[] nums) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                if (++dict[num] > nums.Length / 2) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MajorityElement(new[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 });
        Console.WriteLine(ans);
    }
}