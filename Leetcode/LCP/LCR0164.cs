/*
 * Author: Deean
 * Date: 2023-12-07 22:56:04
 * FileName: LCR0164.cs
 * Description: LCR 164. 破解闯关密码
 */

using System;

namespace LCP;

public class LCR0164 {
    public class Solution {
        public string CrackPassword(int[] password) {
            string[] ss = new string[password.Length];
            for (int i = 0; i < password.Length; i++) {
                ss[i] = password[i].ToString();
            }
            Array.Sort(ss, (s1, s2) => string.CompareOrdinal(s1 + s2, s2 + s1));
            return string.Concat(ss);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CrackPassword(new[] { 15, 8, 7 });
        Console.WriteLine(ans);
    }
}