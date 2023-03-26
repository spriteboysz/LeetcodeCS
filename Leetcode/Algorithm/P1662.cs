/*
 * Author: Deean
 * Date: 2023-03-26 13:28:53
 * FileName: P1662.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1662 {
    public class Solution {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
            return Equals(string.Join("", word1), string.Join("", word2));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ArrayStringsAreEqual(new[] { "ab", "c" }, new[] { "a", "bc" });
        Console.WriteLine(ans);
    }
}