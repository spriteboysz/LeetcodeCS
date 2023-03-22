/*
 * Author: Deean
 * Date: 2023-03-21 22:50:48
 * FileName: P2148.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2148 {
    public class Solution {
        public int CountElements(int[] nums) {
            int maximum = Int32.MinValue, minimum = Int32.MaxValue;
            foreach (var num in nums) {
                maximum = Math.Max(maximum, num);
                minimum = Math.Min(minimum, num);
            }
            int cnt = 0;
            foreach (var num in nums) {
                if (num != minimum && num != maximum) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountElements(new[] { -3, 3, 3, 90 });
        Console.WriteLine(ans);
    }
}