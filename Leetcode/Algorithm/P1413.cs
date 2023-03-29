/*
 * Author: Deean
 * Date: 2023-03-29 23:10:47
 * FileName: P1413.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1413 {
    public class Solution {
        public int MinStartValue(int[] nums) {
            int acc = 0, minimum = 0;
            foreach (var num in nums) {
                acc += num;
                minimum = Math.Min(minimum, acc);
            }
            return -minimum + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinStartValue(new[] { -3, 2, -3, 4, 2 });
        Console.WriteLine(ans);
    }
}