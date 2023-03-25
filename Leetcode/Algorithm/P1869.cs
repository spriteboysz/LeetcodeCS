/*
 * Author: Deean
 * Date: 2023-03-24 22:18:12
 * FileName: P1869.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1869 {
    public class Solution {
        public bool CheckZeroOnes(string s) {
            string[] words0 = s.Split('1'), words1 = s.Split('0');
            int max0 = 0, max1 = 0;
            foreach (var c in words0) {
                max0 = Math.Max(max0, c.Length);
            }
            foreach (var c in words1) {
                max1 = Math.Max(max1, c.Length);
            }
            return max1 > max0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckZeroOnes("110100010");
        Console.WriteLine(ans);
    }
}