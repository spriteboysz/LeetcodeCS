/*
 * Author: Deean
 * Date: 2023-05-20 22:24:21
 * FileName: 剑指 Offer 45. 把数组排成最小的数.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_45__把数组排成最小的数 {
    public class Solution {
        public string MinNumber(int[] nums) {
            string[] ss = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++) {
                ss[i] = nums[i].ToString();
            }
            Array.Sort(ss, (s1, s2) => string.CompareOrdinal(s1 + s2, s2 + s1));
            return string.Concat(ss);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinNumber(new[] { 3, 30, 34, 5, 9 });
        Console.WriteLine(ans);
    }
}