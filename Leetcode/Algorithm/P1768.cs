/*
 * Author: Deean
 * Date: 2023-03-25 23:04:46
 * FileName: P1768.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1768 {
    public class Solution {
        public string MergeAlternately(string word1, string word2) {
            int n1 = word1.Length, n2 = word2.Length, pos1 = 0, pos2 = 0;
            StringBuilder ss = new StringBuilder();
            while (pos1 < n1 && pos2 < n2) {
                if (pos1 < n1) {
                    ss.Append(word1[pos1++]);
                }
                if (pos2 < n2) {
                    ss.Append(word2[pos2++]);
                }
            }
            if (pos1 < n1) {
                ss.Append(word1.Substring(pos1));
            }
            if (pos2 < n2) {
                ss.Append(word2.Substring(pos2));
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MergeAlternately("ab", "pqrs");
        Console.WriteLine(ans);
    }
}