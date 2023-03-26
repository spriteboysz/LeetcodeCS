/*
 * Author: Deean
 * Date: 2023-03-26 13:33:56
 * FileName: P1668.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P1668 {
    public class Solution {
        public int MaxRepeating(string sequence, string word) {
            for (int i = sequence.Length/word.Length; i >= 1; i--) {
                string ss = string.Concat(Enumerable.Repeat(word, i));
                // Console.WriteLine(ss);
                if (sequence.Contains(ss)) {
                    return i;
                }
            }
            return 0;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxRepeating("ababc", "ab");
        Console.WriteLine(ans);
    }
}