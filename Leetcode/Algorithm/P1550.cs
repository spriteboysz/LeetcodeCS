/*
 * Author: Deean
 * Date: 2023-03-28 22:48:41
 * FileName: P1550.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1550 {
    public class Solution {
        public bool ThreeConsecutiveOdds(int[] arr) {
            for (int i = 1; i < arr.Length - 1; i++) {
                if (arr[i - 1] % 2 == 1 && arr[i] % 2 == 1 && arr[i + 1] % 2 == 1) {
                    return true;
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ThreeConsecutiveOdds(new[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 });
        Console.WriteLine(ans);
    }
}