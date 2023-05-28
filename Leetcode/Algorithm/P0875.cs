/*
 * Author: Deean
 * Date: 2023-05-28 10:55:00
 * FileName: P0875.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P0875 {
    public class Solution {
        private long Process(int[] piles, int speed) {
            long time = 0;
            foreach (var pile in piles) {
                time += (pile + speed - 1) / speed;
            }
            return time;
        }

        public int MinEatingSpeed(int[] piles, int h) {
            int left = 1, right = piles.Max();
            int k = right;
            while (left < right) {
                int speed = left + (right - left) / 2;
                long time = Process(piles, speed);
                if (time <= h) {
                    k = speed;
                    right = speed;
                } else {
                    left = speed + 1;
                }
            }
            return k;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 6);
        Console.WriteLine(ans);
    }
}