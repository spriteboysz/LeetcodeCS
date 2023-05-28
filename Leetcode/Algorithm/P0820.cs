/*
 * Author: Deean
 * Date: 2023-05-27 22:40:32
 * FileName: P0820.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0820 {
    public class Solution {
        public int MinimumLengthEncoding(string[] words) {
            Array.Sort(words, (s1, s2) => s1.Length - s2.Length);
            int cnt = 0;
            for (int i = 0, n = words.Length; i < n; i++) {
                bool flag = true;
                for (int j = i + 1; j < n; j++) {
                    if (words[j].EndsWith(words[i])) {
                        flag = false;
                        break;
                    }
                }
                if (flag) cnt += words[i].Length + 1;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumLengthEncoding(new[] { "time", "me", "bell" });
        Console.WriteLine(ans);
    }
}