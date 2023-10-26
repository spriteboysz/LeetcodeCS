/*
 * Author: Deean
 * Date: 2023-10-23 21:25:28
 * FileName: LCR0037.cs
 * Description: LCR 037. 行星碰撞
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0037 {
    public class Solution {
        public int[] AsteroidCollision(int[] asteroids) {
            Stack<int> stack = new Stack<int>();
            foreach (var asteroid in asteroids) {
                bool alive = true;
                while (alive && asteroid < 0 && stack.Count > 0 && stack.Peek() > 0) {
                    alive = stack.Peek() < -asteroid;
                    if (stack.Peek() <= -asteroid) {
                        stack.Pop();
                    }
                }
                if (alive) stack.Push(asteroid);
            }
            int[] ans = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--) {
                ans[i] = stack.Pop();
            }
            return ans;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AsteroidCollision(new[] { 5, 10, -5 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}