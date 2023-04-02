/*
 * Author: Deean
 * Date: 2023-04-02 16:42:37
 * FileName: P1002.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P1002 {
    public class Solution {
        public IList<string> CommonChars(string[] words) {
            int[] hash = new int[26];
            foreach (var c in words[0]) {
                hash[c - 'a']++;
            }
            for (int i = 1; i < words.Length; i++) {
                int[] hash1 = new int[26];
                foreach (var c in words[i]) {
                    hash1[c - 'a']++;
                }
                for (int j = 0; j < 26; j++) {
                    hash[j] = Math.Min(hash[j], hash1[j]);
                }
            }
            IList<String> common = new List<String>();
            for (int i = 0; i < 26; i++) {
                while (hash[i] > 0) {
                    common.Add(((char)(i + 'a')).ToString());
                    hash[i]--;
                }
            }
            return common;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CommonChars(new[]{"bella","label","roller"});
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}