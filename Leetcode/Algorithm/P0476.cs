/*
 * Author: Deean
 * Date: 2023-04-04 20:06:59
 * FileName: P0476.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0476 {
    public class Solution {
        public int FindComplement(int num) {
            int sum = 1;
            while (sum < num) {
                sum = sum * 2 + 1;
            }
            return sum - num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindComplement(5);
        Console.WriteLine(ans);
    }
}