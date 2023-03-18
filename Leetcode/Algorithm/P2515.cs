/*
 * Author: Deean
 * Date: 2023-03-18 17:10:29
 * FileName: P2515.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2515 {
    public class Solution {
        public int ClosetTarget(string[] words, string target, int startIndex) {
            int n = words.Length, minimum = words.Length + 1;
            for (int i = 0; i < n; i++) {
                if (string.Equals(target, words[i])) {
                    minimum = Math.Min(minimum, Math.Abs(i - startIndex));
                    minimum = Math.Min(minimum, n - Math.Abs(i - startIndex));
                }
            }
            return minimum >= n ? -1 : minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ClosetTarget(new[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1);
        Console.WriteLine(ans);
    }
}