/*
 * Author: Deean
 * Date: 2023-04-02 16:11:05
 * FileName: P1013.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1013 {
    public class Solution {
        public bool CanThreePartsEqualSum(int[] arr) {
            int sum = arr.Sum();
            if (sum % 3 != 0) return false;
            sum /= 3;
            int acc = 0, cnt = 0;
            foreach (var num in arr) {
                acc += num;
                if (acc == sum) {
                    cnt++;
                    acc = 0;
                }
            }
            return cnt >= 3;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanThreePartsEqualSum(new[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 });
        Console.WriteLine(ans);
    }
}