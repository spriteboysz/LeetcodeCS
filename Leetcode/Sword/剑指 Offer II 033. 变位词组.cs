/*
 * Author: Deean
 * Date: 2023-05-21 23:07:44
 * FileName: 剑指 Offer II 033. 变位词组.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib;

namespace Sword;

public class 剑指_Offer_II_033__变位词组 {
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
        Console.WriteLine(Arrays.ToString(ans));
    }
}