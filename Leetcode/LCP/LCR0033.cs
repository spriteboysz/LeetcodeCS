/*
 * Author: Deean
 * Date: 2023-10-22 21:52:40
 * FileName: LCR0033.cs
 * Description: LCR 033. 字母异位词分组
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCP;

public class LCR0033 {
    public class Solution {
        private string Process(string s) {
            int[] alphabet = new int[26];
            foreach (var c in s) {
                alphabet[c - 'a']++;
            }
            StringBuilder ss = new StringBuilder();
            foreach (var num in alphabet) {
                ss.Append("#").Append(num);
            }
            return ss.ToString();
        }

        public IList<IList<string>> GroupAnagrams(string[] strs) {
            IDictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (var str in strs) {
                string key = Process(str);
                if (!dict.ContainsKey(key)) {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            return dict.Values.ToList();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        Console.WriteLine(ans);
    }
}