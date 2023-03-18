/*
 * Author: Deean
 * Date: 2023-03-18 19:45:15
 * FileName: P2451.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm;

public class P2451 {
    public class Solution {
        public string Process(string s) {
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++) {
                ss.Append((s[i + 1] - s[i]).ToString());
                ss.Append("#");
            }
            return ss.ToString();
        }

        public string OddString(string[] words) {
            Dictionary<string, string> hash = new Dictionary<string, string>();
            string v = Process(words[0]);
            hash.Add(v, words[0]);
            if (v == Process(words[1])) {
                for (int i = 2; i < words.Length; i++) {
                    string vi = Process(words[i]);
                    if (!hash.ContainsKey(vi)) {
                        return words[i];
                    }
                }
            } else {
                if (v == Process(words[2])) {
                    return words[1];
                }
                return words[0];
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.OddString(new[] { "adc", "wzy", "abc" });
        Console.WriteLine(ans);
    }
}