/*
 * Author: Deean
 * Date: 2023-04-08 16:22:59
 * FileName: 剑指 Offer 53 - II. 0～n-1中缺失的数字.cs
 * Description:
*/

using System;
using System.Linq;

namespace Sword;

public class 剑指_Offer_53___II__0_n_1中缺失的数字 {
    public class Solution {
        public int MissingNumber(int[] nums) {
            int n = nums.Length;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MissingNumber(new[] { 0, 1, 3 });
        Console.WriteLine(ans);
    }
}