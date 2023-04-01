/*
 * Author: Deean
 * Date: 2023-03-31 22:02:03
 * FileName: P1295.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1295 {
    public class Solution {
        public int FindNumbers(int[] nums) {
            int count = 0;
            foreach (var num in nums) {
                int cnt = 0, cur = num;
                while (cur > 0) {
                    cur /= 10;
                    cnt++;
                }
                if (cnt % 2 == 0) count++;
            }
            return count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindNumbers(new[] { 12, 345, 2, 6, 7896 });
        Console.WriteLine(ans);
    }
}