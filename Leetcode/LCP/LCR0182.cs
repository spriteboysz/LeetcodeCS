/*
 * Author: Deean
 * Date: 2023-12-21 22:43:00
 * FileName: LCR0182.cs
 * Description: LCR 182. 动态口令
 */

using System;

namespace LCP;

public class LCR0182 {
    public class Solution {
        public string DynamicPassword(string password, int target) {
            return password.Substring(target) + password.Substring(0, target);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DynamicPassword("s3cur1tyC0d3", 4);
        Console.WriteLine(ans);
    }
}