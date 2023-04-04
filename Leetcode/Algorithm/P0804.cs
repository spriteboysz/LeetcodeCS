/*
 * Author: Deean
 * Date: 2023-04-04 10:53:47
 * FileName: P0804.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P0804 {
    public class Solution {
        public int UniqueMorseRepresentations(string[] words) {
            string[] moss = {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            HashSet<string> set = new HashSet<string>();
            foreach (var word in words) {
                StringBuilder ss = new StringBuilder();
                foreach (var c in word) {
                    ss.Append(moss[c - 'a']);
                }
                set.Add(ss.ToString());
            }
            return set.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.UniqueMorseRepresentations(new[] { "gin", "zen", "gig", "msg" });
        Console.WriteLine(ans);
    }
}