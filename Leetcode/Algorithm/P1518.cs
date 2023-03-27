/*
 * Author: Deean
 * Date: 2023-03-27 23:27:49
 * FileName: P1518.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1518 {
    public class Solution {
        public int NumWaterBottles(int numBottles, int numExchange) {
            int num = numBottles;
            while (numBottles >= numExchange) {
                num += numBottles / numExchange;
                numBottles = numBottles % numExchange + numBottles / numExchange;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumWaterBottles(15, 4);
        Console.WriteLine(ans);
    }
}