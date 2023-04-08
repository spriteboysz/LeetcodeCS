/*
 * Author: Deean
 * Date: 2023-04-08 12:59:54
 * FileName: 剑指 Offer 03. 数组中重复的数字.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_03__数组中重复的数字 {
    public class Solution {
        public int FindRepeatNumber(int[] nums) {
            HashSet<int> seen = new HashSet<int>();
            foreach (var num in nums) {
                if (seen.Contains(num)) {
                    return num;
                }
                seen.Add(num);
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindRepeatNumber(new[] { 2, 3, 1, 0, 2, 5, 3 });
        Console.WriteLine(ans);
    }
}