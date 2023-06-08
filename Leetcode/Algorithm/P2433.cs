/*
 * Author: Deean
 * Date: 2023-06-07 22:46:46
 * FileName: P2433.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2433 {
    public class Solution {
        public int[] FindArray(int[] pref) {
            int n = pref.Length;
            int[] res = new int[n];
            res[0] = pref[0];
            for (int i = 1; i < n; i++) {
                res[i] = pref[i - 1] ^ pref[i];
            }
            return res;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindArray(new[] { 5, 2, 0, 3, 1 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}