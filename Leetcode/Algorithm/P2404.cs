/*
 * Author: Deean
 * Date: 2023-03-18 23:18:48
 * FileName: P2404.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2404 {
    public class Solution {
        public int MostFrequentEven(int[] nums) {
            int[] number = new int[100001];
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    number[num]++;
                }
            }
            int maximum = -1;
            for (int i = 0; i < 100001; i++) {
                if (number[i] > 0) {
                    maximum = Math.Max(maximum, number[i]);
                }
            }
            for (int i = 0; i < 100001; i++) {
                if (number[i] == maximum) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MostFrequentEven(new[] { 0, 1, 2, 2, 4, 4, 1 });
        Console.WriteLine(ans);
    }
}