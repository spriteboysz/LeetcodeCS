/*
 * Author: Deean
 * Date: 2023-04-08 22:19:18
 * FileName: 面试题 17.04. 消失的数字.cs
 * Description:
*/

using System;
using System.Linq;

namespace Interview;

public class 面试题_17_04__消失的数字 {
    public class Solution {
        public int MissingNumber(int[] nums) {
            int n = nums.Length;
            return n * (n + 1) / 2 - nums.Sum();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MissingNumber(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        Console.WriteLine(ans);
    }
}