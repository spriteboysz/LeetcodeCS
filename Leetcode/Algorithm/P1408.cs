/*
 * Author: Deean
 * Date: 2023-03-29 23:14:22
 * FileName: P1408.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1408 {
    public class Solution {
        public IList<string> StringMatching(string[] words) {
            Array.Sort(words, (word1, word2) => word1.Length - word2.Length);
            IList<string> match = new List<string>();
            for (int i = 0; i < words.Length; i++) {
                for (int j = i + 1; j < words.Length; j++) {
                    if (words[j].Contains(words[i])) {
                        match.Add(words[i]);
                        break;
                    }
                }
            }
            return match;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.StringMatching(new[] { "mass", "as", "hero", "superhero" });
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}