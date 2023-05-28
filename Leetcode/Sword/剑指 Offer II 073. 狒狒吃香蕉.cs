/*
 * Author: Deean
 * Date: 2023-05-28 10:45:58
 * FileName: 剑指 Offer II 073. 狒狒吃香蕉.cs
 * Description:
*/

using System;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_073__狒狒吃香蕉 {
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
        var ans = s.MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 5);
        Console.WriteLine(ans);
    }
}