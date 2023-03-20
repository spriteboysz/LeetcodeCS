/*
 * Author: Deean
 * Date: 2023-03-20 23:20:53
 * FileName: P2114.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2114 {
    public class Solution {
        public int MostWordsFound(string[] sentences) {
            return sentences.Select(sentence => sentence.Split(' ').Length).Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MostWordsFound(new[]
            { "alice and bob love leetcode", "i think so too", "this is great thanks very much" });
        Console.WriteLine(ans);
    }
}