/*
 * Author: Deean
 * Date: 2023-04-02 16:18:15
 * FileName: P1009.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1009 {
    public class Solution {
        public int BitwiseComplement(int n) {
            int sum = 1;
            while (sum < n) {
                sum = sum * 2 + 1;
            }
            return sum - n;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BitwiseComplement(10);
        Console.WriteLine(ans);
    }
}