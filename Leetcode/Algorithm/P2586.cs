/*
 * Author: Deean
 * Date: 2023-03-18 13:56:50
 * FileName: P2586.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2586 {
    public class Solution {
        public int VowelStrings(string[] words, int left, int right) {
            int cnt = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'o', 'i', 'u' };
            for (int i = left; i <= right; i++) {
                if (vowels.Contains(words[i][0]) &&
                    vowels.Contains(words[i][words[i].Length - 1])) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.VowelStrings(new[] { "hey", "aeo", "mu", "ooo", "artro" }, 1, 4);
        Console.WriteLine(ans);
    }
}