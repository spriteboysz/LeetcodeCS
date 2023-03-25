/*
 * Author: Deean
 * Date: 2023-03-24 22:07:28
 * FileName: P1880.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1880 {
    public class Solution {
        private long Process(string word) {
            return word.Aggregate(0L, (current, c) => current * 10 + c - 'a');
        }

        public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
            return Process(firstWord) + Process(secondWord) == Process(targetWord);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSumEqual("acb", "cba", "cdb");
        Console.WriteLine(ans);
    }
}