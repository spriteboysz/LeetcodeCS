/*
 * Author: Deean
 * Date: 2023-03-29 22:44:34
 * FileName: P142.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1422 {
    public class Solution {
        public int MaxScore(string s) {
            int score = 0;
            int n = s.Length;
            if (s[0] == '0') {
                score++;
            }
            for (int i = 1; i < n; i++) {
                if (s[i] == '1') {
                    score++;
                }
            }
            int maximum = score;
            for (int i = 1; i < n - 1; i++) {
                if (s[i] == '0') {
                    score++;
                } else {
                    score--;
                }
                maximum = Math.Max(maximum, score);
            }
            return maximum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxScore("011101");
        Console.WriteLine(ans);
    }
}