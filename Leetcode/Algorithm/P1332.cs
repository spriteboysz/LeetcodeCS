/*
 * Author: Deean
 * Date: 2023-03-31 20:54:53
 * FileName: P1332.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1332 {
    public class Solution {
        public int RemovePalindromeSub(string s) {
            int n = s.Length;
            for (int i = 0; i < n / 2; i++) {
                if (s[i] != s[n - 1 - i]) {
                    return 2;
                }
            }
            return 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemovePalindromeSub("ababa");
        Console.WriteLine(ans);
    }
}