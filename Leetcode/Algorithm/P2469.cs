/*
 * Author: Deean
 * Date: 2023-03-18 19:18:12
 * FileName: P2469.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2469 {
    public class Solution {
        public double[] ConvertTemperature(double celsius) {
            return new[] { celsius + 273.15, celsius * 1.8 + 32.0 };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertTemperature(36.50);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}