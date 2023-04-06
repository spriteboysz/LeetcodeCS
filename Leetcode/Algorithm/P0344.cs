/*
 * Author: Deean
 * Date: 2023-04-06 23:07:00
 * FileName: P0344.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0344 {
    public class Solution {
        public void ReverseString(char[] s) {
            int n = s.Length;
            for (int i = 0; i < n/2; i++) {
                char c = s[i];
                s[i] = s[n - 1 - i];
                s[n - 1 - i] = c;
            }
            Console.WriteLine(lib.Arrays.ToString(s));
        }
    }

    public static void Test() {
        var s = new Solution();
        s.ReverseString(new[] { 'h', 'e', 'l', 'l', 'o' });
    }
}