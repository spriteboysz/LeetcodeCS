/*
 * Author: Deean
 * Date: 2023-03-19 13:14:03
 * FileName: P2239.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2239 {
    public class Solution {
        public int FindClosestNumber(int[] nums) {
            int[] number = new int[100001];
            foreach (var num in nums) {
                if (num >= 0) {
                    number[num] |= 2;
                } else {
                    number[-num] |= 1;
                }
            }
            for (int i = 0; i < 100001; i++) {
                if (number[i] != 0) {
                    return number[i] == 1 ? -i : i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindClosestNumber(new[] { -4, -2, 1, 4, 8 });
        Console.WriteLine(ans);
    }
}