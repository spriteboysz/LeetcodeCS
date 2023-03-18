/*
 * Author: Deean
 * Date: 2023-03-18 16:56:52
 * FileName: P2525.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2525 {
    public class Solution {
        public string CategorizeBox(int length, int width, int height, int mass) {
            long volume = (long)length * width * height;
            bool bulky = volume >= Math.Pow(10, 9) || length >= 10000 || width >= 10000 || height >= 10000;
            bool heavy = mass >= 100;
            if (bulky && heavy) return "Both";
            if (bulky) return "Bulky";
            if (heavy) return "Heavy";
            return "Neither";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CategorizeBox(1000, 35, 700, 300);
        Console.WriteLine(ans);
    }
}