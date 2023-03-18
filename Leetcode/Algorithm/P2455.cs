/*
 * Author: Deean
 * Date: 2023-03-18 19:37:47
 * FileName: P2455.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2455 {
    public class Solution {
        public int AverageValue(int[] nums) {
            int sum = 0, cnt = 0;
            foreach (var num in nums) {
                if (num % 6 == 0) {
                    sum += num;
                    cnt++;
                }
            }
            return cnt == 0 ? 0 : sum / cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AverageValue(new[] { 1, 3, 6, 10, 12, 15 });
        Console.WriteLine(ans);
    }
}