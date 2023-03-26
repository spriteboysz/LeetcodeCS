/*
 * Author: Deean
 * Date: 2023-03-26 10:21:56
 * FileName: P1624.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1624 {
    public class Solution {
        public int MaxLengthBetweenEqualCharacters(string s) {
            int[] index = new int[26];
            for (int i = 0; i < 26; i++) {
                index[i] = -1;
            }
            int maximum = -1;
            for (int i = 0; i < s.Length; i++) {
                int j = s[i] - 'a';
                if (index[j] == -1) {
                    index[j] = i;
                } else {
                    maximum = Math.Max(maximum, i - index[j] - 1);
                }
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxLengthBetweenEqualCharacters("abca");
        Console.WriteLine(ans);
    }
}