/*
 * Author: Deean
 * Date: 2023-04-08 22:16:29
 * FileName: 面试题 17.10. 主要元素.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Interview;

public class 面试题_17_10__主要元素 {
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
        var ans = s.MajorityElement(new[] { 1, 2, 5, 9, 5, 9, 5, 5, 5 });
        Console.WriteLine(ans);
    }
}